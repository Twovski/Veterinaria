using System;
using System.Drawing;
using System.Windows.Forms;
using Negocio;

namespace Fronts {
    public partial class Veterinario : Form {
        private NegocioVeterinario _negocio = new NegocioVeterinario();
        
        public Veterinario() {
            InitializeComponent();
            TablaVeterinario.DataSource = _negocio.GetListado("SELECT * FROM VW_Veterinario");
            TextVetID.Controls[0].Visible = false;
            TextVetID.Text = "";
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                TablaVeterinario.DataSource = _negocio.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaVeterinario.DataSource = _negocio.GetListado("SELECT * FROM VW_Veterinario");
                    LabelCheck(new []{ "Nombre", "Apellido Paterno", "Apellido Materno", "RFC", "Correo" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "Nombre", "Apellido Paterno", "Apellido Materno", "RFC", "Correo" });
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaVeterinario.DataSource = _negocio.GetListado("SELECT * FROM VW_Veterinario");
                    LabelCheck(new []{ "VetID", "Apellido Paterno", "Apellido Materno", "Nombre", "RFC", "Correo" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "VetID", "Apellido Paterno", "Apellido Materno", "Nombre", "RFC", "Correo" });
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaVeterinario.DataSource = _negocio.GetListado("SELECT * FROM VW_Veterinario");
                    LabelCheck(new []{ "VetID" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "VetID" });
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
            return "UPDATE Veterinario SET Status = 0 WHERE VetID = " + TextVetID.Text;
        }
        
        private string QueryEditar() {
            string[] columns = { "Nombre", "Apellido Paterno", "Apellido Materno", "RFC", "Correo" };    
            string query = "UPDATE Veterinario ";
            string condition = "SET ";

            foreach (string column in columns) {
                string result = GetColumn(column);
                query += $"{condition} [{column}] = {IsNull(result)}";
                condition = ", ";
            }
            
            query += " WHERE VetID = " + TextVetID.Text;
            
            return query;
        }
        
        private string QueryGuardar() {
            string[] columns = { "Nombre", "Apellido Paterno", "Apellido Materno", "RFC", "Correo" };
            string query = "INSERT INTO Veterinario(";
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
            string[] columns = { "VetID", "Apellido Paterno", "Apellido Materno", "Nombre", "RFC", "Correo" };
            string query = "SELECT * FROM VW_Veterinario";
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
                case "VetID":
                    return TextVetID.Text;
                case "Apellido Paterno":
                    return TextAP.Text;
                case "Apellido Materno":
                    return TextAM.Text;
                case "Nombre":
                    return TextNombre.Text;
                case "RFC":
                    return TextRFC.Text;
                case "Correo":
                    return TextCorreo.Text;
                default:
                    return "";
            }
        }

        private Label GetLabel(string column) {
            switch (column) {
                case "VetID":
                    return LabelVetID;
                case "Apellido Paterno":
                    return LabelAP;
                case "Apellido Materno":
                    return LabelAM;
                case "Nombre":
                    return LabelNombre;
                case "RFC":
                    return LabelRFC;
                case "Correo":
                    return LabelCorreo;
                default:
                    return null;
            }
        }
        
        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Consultar Veterinario";
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Veterinario";
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Veterinario";
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Veterinario";
        }


        private void TablaVeterinario_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;
            
            TablaVeterinario.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaVeterinario.Rows[e.RowIndex].Cells;
            TextVetID.Text = Column["VetID"].Value.ToString().Trim();
            TextNombre.Text = Column["Nombre"].Value.ToString().Trim();
            TextRFC.Text = Column["RFC"].Value.ToString().Trim();
            TextCorreo.Text = Column["Correo"].Value.ToString().Trim();
        }
    }
}