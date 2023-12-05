using System;
using System.Data.SqlClient;
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
                    LabelCheck(new []{ "Nombre", "Apellido Paterno", "Apellido Materno", "RFC", "Correo" });
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    int vetID = _negocio.ScopeIdentity();
                    _negocio.Execute($"INSERT INTO Autenticacion(VetID) VALUES({vetID})");
                    TablaVeterinario.DataSource = _negocio.GetListado("SELECT * FROM VW_Veterinario");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Guardado Exitosamente", "Crear Veterinario" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    if (exception.Number == 2627) 
                        MessageBox.Show("No se pueden repetir los datos de estos campos(RFC, Correo)", 
                            "Advertencia" , 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning);
                    else
                        Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                    
                    Console.WriteLine(exception);
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    LabelCheck(new []{ "VetID", "Apellido Paterno", "Apellido Materno", "Nombre", "RFC", "Correo" });
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaVeterinario.DataSource = _negocio.GetListado("SELECT * FROM VW_Veterinario");
                    MessageBox.Show("Editado Exitosamente", "Editar Veterinario" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    LabelCheck(new []{ "VetID" });
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaVeterinario.DataSource = _negocio.GetListado("SELECT * FROM VW_Veterinario");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Eliminado Exitosamente", "Eliminar Veterinario" , MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            return "UPDATE Veterinario SET Status = 0 WHERE VetID = " + TextVetID.Text;
        }
        
        private string QueryEditar() {
            string[] columns = { "Nombre", "Apellido Paterno", "Apellido Materno", "RFC", "Correo" };    
            string query = "UPDATE Veterinario ";
            string condition = "SET ";

            foreach (string column in columns) {
                string result = GetColumn(column);
                if (!string.IsNullOrWhiteSpace(result)) {
                    query += $"{condition} [{column}] = {IsNull(result)}";
                    condition = ", ";
                }
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
            Titulo.Text = "Buscar Veterinario";
            TextVetID.ReadOnly = false;
            TextNombre.ReadOnly = false;
            TextAP.ReadOnly = false;
            TextAM.ReadOnly = false;
            TextCorreo.ReadOnly = false;
            TextRFC.ReadOnly = false;
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Veterinario";
            TextVetID.ReadOnly = true;
            TextNombre.ReadOnly = false;
            TextAP.ReadOnly = false;
            TextAM.ReadOnly = false;
            TextCorreo.ReadOnly = false;
            TextRFC.ReadOnly = false;
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Veterinario";
            TextVetID.ReadOnly = true;
            TextNombre.ReadOnly = true;
            TextAP.ReadOnly = true;
            TextAM.ReadOnly = true;
            TextCorreo.ReadOnly = true;
            TextRFC.ReadOnly = true;
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Veterinario";
            TextVetID.ReadOnly = true;
            TextNombre.ReadOnly = false;
            TextAP.ReadOnly = false;
            TextAM.ReadOnly = false;
            TextCorreo.ReadOnly = false;
            TextRFC.ReadOnly = false;
        }
        
        private void TablaVeterinario_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;
            
            TablaVeterinario.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaVeterinario.Rows[e.RowIndex].Cells;
            TextVetID.Text = Column["VetID"].Value.ToString().Trim();
            TextAP.Text = Column["Apellido Paterno"].Value.ToString().Trim();
            TextAM.Text = Column["Apellido Materno"].Value.ToString().Trim();
            TextNombre.Text = Column["Nombre"].Value.ToString().Trim();
            TextRFC.Text = Column["RFC"].Value.ToString().Trim();
            TextCorreo.Text = Column["Correo"].Value.ToString().Trim();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e) {
            TextVetID.Text = "";
            TextNombre.Text = "";
            TextAP.Text = "";
            TextAM.Text = "";
            TextCorreo.Text = "";
            TextRFC.Text = "";
        }
    }
}