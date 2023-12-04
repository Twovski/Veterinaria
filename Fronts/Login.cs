using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
    public partial class Login : Form {
        private NegocioVeterinario _negocio = new NegocioVeterinario();
        public EntidadVeterinario EVeterinario;
        
        public Login() {
            InitializeComponent();
            BoxVetID.DataSource = _negocio.ListaVeterinario();
            BoxVetID.DisplayMember = "Nombre";
            BoxVetID.ValueMember = "VetID";
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            LabelCheck(new []{ "VetID", "Contraseña" });
            string query = QueryConsulta();
            EVeterinario = _negocio.Login(query);
            if (EVeterinario != null) 
                Close();
            else 
                MessageBox.Show("Contraseña incorrecta", "Login" , MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
        private string QueryConsulta() {
            string[] columns = { "VetID", "Contraseña" };
            string query = $"SELECT * FROM Veterinario";
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