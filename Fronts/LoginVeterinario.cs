using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
    public partial class LoginVeterinario : Form {
        private NegocioVeterinario _negocio = new NegocioVeterinario();
        public EntidadVeterinario EVeterinario = null;
        
        public LoginVeterinario() {
            InitializeComponent();
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            string query = QueryConsulta();
            EVeterinario = _negocio.Login(query);
            if(EVeterinario != null)
                Close();
            LabelCheck(new []{ "RFC" });
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
            string[] columns = { "RFC" };
            string query = $"SELECT * FROM VW_Veterinario";
            string condition = " WHERE";

            foreach (string column in columns) {
                string result = GetColumn(column);
                query += condition + $" [{column}] = '{result}'";
                condition = " AND";
            }
            
            return query;
        }
        
        private string GetColumn(string column) {
            switch (column) {
                case "RFC":
                    return TextRFC.Text;
                default:
                    return "";
            }
        }

        private Label GetLabel(string column) {
            switch (column) {
                case "RFC":
                    return LabelRFC;
                default:
                    return null;
            }
        }
    }
}