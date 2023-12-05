using System;
using System.Windows.Forms;
using Entidades;

namespace Fronts {
    public partial class Expediente : Form {
        private EntidadVeterinario _veterinario;
        public Expediente() {
            InitializeComponent();
        }

        private void BotonHistorial_Click(object sender, EventArgs e) {
            Consultas historial = new Consultas(_veterinario);
            historial.ShowDialog();
        }


        private void OpcionLogin_Click(object sender, EventArgs e) {
            Login login = new Login(null,false);
            login.ShowDialog();
            if (login.EVeterinario == null) 
                return;

            BotonHistorial.Enabled = true;
            BotonDesparasitante.Enabled = true;
            BotonVacunas.Enabled = true;
            OpcionCC.Enabled = true;
            OpcionLogin.Text = login.EVeterinario.Nombre;
            OpcionLogin.Enabled = false;
           _veterinario = login.EVeterinario;
        }

        private void BotonVacunas_Click(object sender, EventArgs e) {
            new Vacunas().ShowDialog();
        }

        private void BotonDesparasitante_Click(object sender, EventArgs e) {
            new Desparasitante().ShowDialog();
        }

        private void OpcionCC_Click(object sender, EventArgs e) {
            
            new Login(_veterinario, true).ShowDialog();
        }
        
    }
}