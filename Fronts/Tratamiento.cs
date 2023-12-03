using System;
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
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_Tratamiento");
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
                    TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_Tratamiento");
                    LabelCheck(new []{ "TraID", "TraID", "Nombre" });
                }
                catch (Exception exception) {
                    Console.WriteLine(exception);
                    LabelCheck(new []{ "TraID", "TraID", "Nombre" });
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaTT.DataSource = _negocio.GetListado("SELECT * FROM VW_Tratamiento");
                    LabelCheck(new []{ "TraID" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "TraID" });
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
                query += $"{condition} [{column}] = {IsNull(result)}";
                condition = ", ";
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
            Titulo.Text = "Consultar Tratamiento";
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Tratamiento";
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Tratamiento";
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Tratamiento";
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
    }
}