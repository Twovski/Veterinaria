using System;
using System.Drawing;
using System.Windows.Forms;
using Negocio;

namespace Fronts {
    public partial class TipoTratamiento : Form {
        private NegocioTipoTratamiento _negocio = new NegocioTipoTratamiento();
        
        public TipoTratamiento() {
            InitializeComponent();
            TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_TipoTratamiento");
            TextTipoID.Controls[0].Visible = false;
            TextTipoID.Text = "";
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                TablaTT.DataSource = _negocio.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_TipoTratamiento");
                    LabelCheck(new []{ "TipoID", "Nombre" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "TipoID", "Nombre" });
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_TipoTratamiento");
                    LabelCheck(new []{ "TipoID", "Nombre" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "TipoID", "Nombre" });
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_TipoTratamiento");
                    LabelCheck(new []{ "TipoID" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "TipoID" });
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
            return "UPDATE TipoTratamiento SET Status = 0 WHERE TipoID = " + TextTipoID.Text;
        }
        
        private string QueryEditar() {
            string[] columns = { "Nombre" };    
            string query = "UPDATE TipoTratamiento ";
            string condition = "SET ";

            foreach (string column in columns) {
                string result = GetColumn(column);
                query += $"{condition} [{column}] = {IsNull(result)}";
                condition = ", ";
            }
            
            query += " WHERE TipoID = " + TextTipoID.Text;
            return query;
        }
        
        private string QueryGuardar() {
            string[] columns = { "Nombre"  };
            string query = "INSERT INTO TipoTratamiento(";
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
            string[] columns = { "TipoID", "Nombre" };
            string query = "SELECT * FROM VW_TipoTratamiento";
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
                case "TipoID":
                    return TextTipoID.Text;
                case "Nombre":
                    return TextNombre.Text;
                default:
                    return "";
            }
        }

        private Label GetLabel(string column) {
            switch (column) {
                case "TipoID":
                    return LabelTipoID;
                case "Nombre":
                    return LabelNombre;
                default:
                    return null;
            }
        }
        
        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Consultar Tipo Tratamiento";
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Tipo Tratamiento";
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Tipo Tratamiento";
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Tipo Tratamiento";
        }
        
        private void TablaTT_CellClick(object sender, DataGridViewCellEventArgs e) {
            TablaTT.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaTT.Rows[e.RowIndex].Cells;
            TextTipoID.Text = Column["TipoID"].Value.ToString().Trim();
            TextNombre.Text = Column["Nombre"].Value.ToString().Trim();
        }
    }
}