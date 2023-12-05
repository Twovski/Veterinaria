using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Negocio;

namespace Fronts {
    public partial class Servicio : Form {
        private NegocioServicio _negocio = new NegocioServicio();
        
        public Servicio() {
            InitializeComponent();
            TablaServicio.DataSource = _negocio.GetListado("SELECT * FROM VW_Servicio");
            TextServID.Controls[0].Visible = false;
            TextServID.Text = "";
        }
        
        private void LabelCheck(string[] columns) {
            foreach (string column in columns) {
                string text = GetColumn(column);
                if (string.IsNullOrWhiteSpace(text)) 
                    GetLabel(column).ForeColor = Color.Red;
                else 
                    GetLabel(column).ForeColor = Color.Black;
            }
        }

        private string QueryBaja() {
            return "UPDATE Servicio SET Status = 0 WHERE ServID = " + TextServID.Text;
        }
        
        private string QueryEditar() {
            string[] columns = { "Nombre" };    
            string query = "UPDATE Servicio ";
            string condition = "SET ";

            foreach (string column in columns) {
                string result = GetColumn(column);
                if (!string.IsNullOrWhiteSpace(result)) {
                    query += $"{condition} [{column}] = {IsNull(result)}";
                    condition = ", ";
                }
            }
            
            query += " WHERE ServID = " + TextServID.Text;
            return query;
        }
        
        private string QueryGuardar() {
            string[] columns = { "Nombre"  };
            string query = "INSERT INTO Servicio(";
            query += "[" + string.Join("], [", columns) + "]";
            query += ") VALUES (";
            
            foreach (string column in columns) {
                string result = GetColumn(column);
                query += $"{IsNull(result)}, ";
            }
            
            query = query.TrimEnd(' ', ',') + ")";
            return query;
        }

        private string QueryConsulta() {
            string[] columns = { "ServID", "Nombre" };
            string query = "SELECT * FROM VW_Servicio";
            string condition = " WHERE";

            foreach (string column in columns) {
                string result = GetColumn(column);
                if (!string.IsNullOrWhiteSpace(result)) {
                    query += condition + $" [{column}] = '{result}'";
                    condition = " AND";
                }
            }
            
            return query;
        }
        
        private string IsNull(string text) {
            return string.IsNullOrWhiteSpace(text) ? "null" : "'" + text + "'";
        }
        
        private string GetColumn(string column) {
            switch (column) {
                case "ServID":
                    return TextServID.Text;
                case "Nombre":
                    return TextNombre.Text;
                default:
                    return "";
            }
        }

        private Label GetLabel(string column) {
            switch (column) {
                case "ServID":
                    return LabelServID;
                case "Nombre":
                    return LabelNombre;
                default:
                    return null;
            }
        }
        
        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Buscar Servicio";
            TextNombre.ReadOnly = false;
            TextServID.ReadOnly = false;
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Servicio";
            TextNombre.ReadOnly = false;
            TextServID.ReadOnly = true;
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Servicio";
            TextNombre.ReadOnly = true;
            TextServID.ReadOnly = true;
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Servicio";
            TextNombre.ReadOnly = false;
            TextServID.ReadOnly = true;
        }

        private void TablaServicio_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;
            
            TablaServicio.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaServicio.Rows[e.RowIndex].Cells;
            TextServID.Text = Column["ServID"].Value.ToString().Trim();
            TextNombre.Text = Column["Nombre"].Value.ToString().Trim();
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                TablaServicio.DataSource = _negocio.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    LabelCheck(new []{ "Nombre" });
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaServicio.DataSource = _negocio.GetListado("SELECT * FROM VW_Servicio");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Guardado Exitosamente", "Guardar Servicio" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) { 
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    LabelCheck(new []{ "ServID", "Nombre" });
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaServicio.DataSource = _negocio.GetListado("SELECT * FROM VW_Servicio");
                    MessageBox.Show("Editar Exitosamente", "Editar Servicio" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    LabelCheck(new []{ "ServID" });
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaServicio.DataSource = _negocio.GetListado("SELECT * FROM VW_Servicio");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Eliminado Exitosamente", "Eliminar Servicio" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
        }

        private void BotonLimpiar_Click(object sender, EventArgs e) {
            TextServID.Text = "";
            TextNombre.Text = "";
        }
    }
}