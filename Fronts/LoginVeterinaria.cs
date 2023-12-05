using System;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
    public partial class LoginVeterinaria : Form {
        private NegocioCliente _negocio = new NegocioCliente();
        public EntidadVeterinaria Veterinaria;
        
        public LoginVeterinaria() {
            InitializeComponent();
            BoxVeterinaria.DataSource = _negocio.ListaVeterinaria();
            BoxVeterinaria.DisplayMember = "Nombre";
            BoxVeterinaria.ValueMember = "VetID";
        }


        private void Boton_Click(object sender, EventArgs e) {
            Veterinaria = (EntidadVeterinaria) BoxVeterinaria.SelectedItem;
            if (Veterinaria.VetID != -1) {
                Close();
                return;   
            }
            
            MessageBox.Show("Porfavor selecciona una veterinaria", "Seleccion Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}