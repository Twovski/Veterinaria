using System;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
    public partial class LoginVeterinaria : Form {
        private NegocioLoginVeterinaria _negocioLoginVeterinaria = new NegocioLoginVeterinaria();
        private NegocioCliente _negocioCliente = new NegocioCliente();
        
        public LoginVeterinaria() {
            InitializeComponent();
            _negocioLoginVeterinaria.StartConexion();
            BoxVeterinaria.DataSource = _negocioCliente.ListaVeterinaria();
            BoxVeterinaria.DisplayMember = "Nombre";
            BoxVeterinaria.ValueMember = "VetID";
        }


        private void Boton_Click(object sender, EventArgs e) {
            Menu menu = new Menu();
            EntidadVeterinaria veterinaria = (EntidadVeterinaria) BoxVeterinaria.SelectedItem;
            if (veterinaria.VetID == -1) {
                MessageBox.Show("Porfavor selecciona una veterinaria", "Seleccion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            menu.veterinaria = veterinaria;
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}