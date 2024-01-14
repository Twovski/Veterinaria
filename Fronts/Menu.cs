using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Timer = System.Timers.Timer;

namespace Fronts {
    public partial class Menu : Form {
        private NegocioMenu _negocioMenu = new NegocioMenu();
        private LoginVeterinaria LoginVeterinaria;
        public EntidadVeterinaria veterinaria { get; set; }
        
        public Menu() {
            InitializeComponent();
            Timer timer = new Timer(60000);
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e) {
            string mensaje = _negocioMenu.ObtenerNotificacion();
            if(mensaje == null)
                return;

            Notificacion.BalloonTipText = mensaje;
            Notificacion.ShowBalloonTip(1000);
        }
        
        private void BotonCliente_Click(object sender, EventArgs e) {
            new Cliente(veterinaria.Nombre).ShowDialog();      
        }

        private void BotonPaciente_Click(object sender, EventArgs e) {
            new Paciente(false).ShowDialog();
        }

        private void OpcionVeterinario_Click(object sender, EventArgs e) {
            new Veterinario().ShowDialog();
        }

        private void OpcionServicio_Click(object sender, EventArgs e) {
            new Servicio().ShowDialog();
        }

        private void BotonExpediente_Click(object sender, EventArgs e) {
            new Expediente().ShowDialog();
        }

        private void OpcionTratamiento_Click(object sender, EventArgs e) {
            new Tratamiento().ShowDialog();
        }


        private void OpcionInfo_Click(object sender, EventArgs e) {
            MessageBox.Show(@"Ochoa Flores Francisco", "Creadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}