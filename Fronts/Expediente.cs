using System;
using System.Windows.Forms;
using Entidades;

namespace Fronts {
    public partial class Expediente : Form {
        private EntidadVeterinario _veterinario;
        private EntidadPaciente _paciente;
        
        public Expediente() {
            InitializeComponent();
        }

        private void BotonHistorial_Click(object sender, EventArgs e) {
            Consultas historial = new Consultas(_veterinario, _paciente);
            historial.ShowDialog();
        }


        private void OpcionLogin_Click(object sender, EventArgs e) {
            Login login = new Login();
            login.ShowDialog();
            if (login.EVeterinario == null) 
                return;

            BotonHistorial.Enabled = true;
            BotonDesparasitante.Enabled = true;
            BotonVacunas.Enabled = true;
           _veterinario = login.EVeterinario;
        }

        private void CPaciente_Click(object sender, EventArgs e) {
            Paciente paciente = new Paciente(true);
            paciente.ShowDialog();
            if (paciente.EPaciente == null) 
                return;
            _paciente = paciente.EPaciente;
        }

        private void BotonVacunas_Click(object sender, EventArgs e) {
            new Vacunas().ShowDialog();
        }

        private void BotonDesparasitante_Click(object sender, EventArgs e) {
            new Desparasitante().ShowDialog();
        }
    }
}