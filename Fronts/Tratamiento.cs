using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Negocio;

namespace Fronts {
    public partial class Tratamiento : Form {
        private NegocioTratamiento _negocio = new NegocioTratamiento();
        
        public Tratamiento() {
            InitializeComponent();
            TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_Tratamiento");
            TextTraID.Controls[0].Visible = false;
            TextTraID.Text = "";
            BoxTipoID.DataSource = _negocio.ListaTipoTratamientos();
            BoxTipoID.DisplayMember = "Nombre";
            BoxTipoID.ValueMember = "TipoID";
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                TablaTT.DataSource = _negocio.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    LabelCheck(new []{ "Nombre" });
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_Tratamiento");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Guardado Exitosamente", "Guardar Tratamiento" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    LabelCheck(new []{ "TraID", "TraID", "Nombre" });
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_Tratamiento");
                    MessageBox.Show("Editado Exitosamente", "Editar Tratamiento" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    LabelCheck(new []{ "TraID" });
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_Tratamiento");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Borrado Exitosamente", "Borrar Tratamiento" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
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
            return "UPDATE Tratamiento SET Status = 0 WHERE TraID = " + TextTraID.Text;
        }
        
        private string QueryEditar() {
            string[] columns = { "Nombre", "TipoID" };    
            string query = "UPDATE Tratamiento ";
            string condition = "SET ";

            foreach (string column in columns) {
                string result = GetColumn(column);
                if (!string.IsNullOrWhiteSpace(result)) {
                    query += $"{condition} [{column}] = {IsNull(result)}";
                    condition = ", ";
                }
            }
            
            query += " WHERE TraID = " + TextTraID.Text;
            return query;
        }
        
        private string QueryGuardar() {
            string[] columns = { "Nombre", "TipoID"  };
            string query = "INSERT INTO Tratamiento(";
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
            string[] columns = { "TipoID", "Nombre", "TraID" };
            string query = "SELECT * FROM VW_Tratamiento";
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
            int id;
            switch (column) {
                case "TraID":
                    return TextTraID.Text;
                case "Nombre":
                    return TextNombre.Text;
                case "TipoID":
                    id = (int) BoxTipoID.SelectedValue;
                    return id == -1 ? "" : Convert.ToString(id);
                default:
                    return "";
            }
        }

        private Label GetLabel(string column) {
            switch (column) {
                case "TraID":
                    return LabelTraID;
                case "Nombre":
                    return LabelNombre;
                case "TipoID":
                    return LabelTipo;
                default:
                    return null;
            }
        }
        
        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Buscar Tratamiento";
            TextTraID.ReadOnly = false;
            TextNombre.ReadOnly = false;
            BoxTipoID.Enabled = true;
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Tratamiento";
            TextTraID.ReadOnly = true;
            TextNombre.ReadOnly = false;
            BoxTipoID.Enabled = true;
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Tratamiento";
            TextTraID.ReadOnly = true;
            TextNombre.ReadOnly = true;
            BoxTipoID.Enabled = true;
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Tratamiento";
            TextTraID.ReadOnly = true;
            TextNombre.ReadOnly = false;
            BoxTipoID.Enabled = false;
        }
        
        private void TablaTT_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;
            
            TablaTT.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaTT.Rows[e.RowIndex].Cells;
            TextTraID.Text = Column["TraID"].Value.ToString().Trim();
            TextNombre.Text = Column["Nombre"].Value.ToString().Trim();
            BoxTipoID.Text = Column["Tipo Tratamiento"].Value.ToString().Trim();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e) {
            TextTraID.Text = "";
            TextNombre.Text = "";
            BoxTipoID.Text = "Selecciona";
        }
    }
}