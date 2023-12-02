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
    }
}