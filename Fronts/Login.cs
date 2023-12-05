using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
    public partial class Login : Form {
        private NegocioVeterinario _negocio = new NegocioVeterinario();
        public EntidadVeterinario EVeterinario;
        public bool Editar;
        public Login(EntidadVeterinario veterinario, bool editar) {
            InitializeComponent();
            BoxVetID.DataSource = _negocio.ListaVeterinario();
            BoxVetID.DisplayMember = "Nombre";
            BoxVetID.ValueMember = "VetID";
            Editar = editar;
            EVeterinario = veterinario;
            if (editar) {
                LabelContraseña.Text = "Cambiar contraseña";
                BoxVetID.Text = EVeterinario.Nombre;
                BoxVetID.Enabled = false;
            }
                
            
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            string query;
            if (Editar) {
                try {
                    LabelCheck(new []{"Contraseña"});
                    query = QueryEditar();
                    Console.WriteLine(query);
                    _negocio.Execute(query);
                    MessageBox.Show("Contraseña cambiada", "Cambiar Contraseña" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (SqlException exception) {
                    MessageBox.Show("Es necesario que ingreses un texto de esta longitud (1 - 50)", "Cambiar Contraseña" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
            
            LabelCheck(new []{ "VetID", "Contraseña" });
            query = QueryGuardar();
            EVeterinario = _negocio.Login(query);
            if (EVeterinario != null) 
                Close();
            else 
                MessageBox.Show("Contraseña incorrecta", "Login" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }
        
        private string IsNull(string text) {
            return string.IsNullOrWhiteSpace(text) ? "null" : "'" + text + "'";
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

        private string QueryEditar() {
            string[] columns = { "Contraseña" };    
            string query = "UPDATE Autenticacion ";
            string condition = "SET ";

            foreach (string column in columns) {
                string result = GetColumn(column);
                if (!string.IsNullOrWhiteSpace(result)) {
                    query += $"{condition} [{column}] = {IsNull(result)}";
                    condition = ", ";
                }
            }
            
            query += " WHERE VetID = " + GetColumn("VetID");
            return query;
        }
        
        private string QueryGuardar() {
            string[] columns = { "VetID", "Contraseña" };
            string query = $"SELECT * FROM VW_Login";
            string condition = " WHERE";

            foreach (string column in columns) {
                string result = GetColumn(column);
                query += condition + $" [{column}] = '{result}'";
                condition = " AND";
            }

            query += " AND Status = 1";
            return query;
        }
        
        private string GetColumn(string column) {
            int id;
            switch (column) {
                case "VetID":
                    id = (int) BoxVetID.SelectedValue;
                    return id == -1 ? "" : Convert.ToString(id);
                case "Contraseña":
                    return TextContraseña.Text;
                default:
                    return "";
            }
        }

        private Label GetLabel(string column) {
            switch (column) {
                case "VetID":
                    return LabelVetID;
                case "Contraseña":
                    return LabelContraseña;
                default:
                    return null;
            }
        }
    }
}