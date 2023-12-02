using System;
using System.Windows.Forms;
using Negocio;

namespace Fronts {
    public partial class Menu : Form {
        private NegocioMenu _negocio = new NegocioMenu();
        public Menu() {
            _negocio.StartConexion();
            InitializeComponent();
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            new Cliente().ShowDialog();        
        }

        private void BotonPaciente_Click(object sender, EventArgs e) {
            new Paciente().ShowDialog();
        }

        private void OpcionVeterinario_Click(object sender, EventArgs e) {
            new Veterinario().ShowDialog();
        }

        private void OpcionServicio_Click(object sender, EventArgs e) {
            new Servicio().ShowDialog();
        }

        private void OpcionTT_Click(object sender, EventArgs e) {
            new TipoTratamiento().ShowDialog();
        }
    }
}