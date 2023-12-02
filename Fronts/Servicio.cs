using System;
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
                query += $"{condition} [{column}] = {IsNull(result)}";
                condition = ", ";
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
            Titulo.Text = "Consultar Servicio";
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Servicio";
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Servicio";
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Servicio";
        }

        private void TablaServicio_CellClick(object sender, DataGridViewCellEventArgs e) {
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
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaServicio.DataSource = _negocio.GetListado("SELECT * FROM VW_Servicio");
                    LabelCheck(new []{ "ServID", "Nombre" });
                }
                catch (Exception exception) { 
                    LabelCheck(new []{ "ServID", "Nombre" });
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaServicio.DataSource = _negocio.GetListado("SELECT * FROM VW_Servicio");
                    LabelCheck(new []{ "ServID", "Nombre" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "ServID", "Nombre" });
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaServicio.DataSource = _negocio.GetListado("SELECT * FROM VW_Servicio");
                    LabelCheck(new []{ "ServID" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "ServID" });
                }
            }
        }
    }
}