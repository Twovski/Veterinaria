using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Fronts {
    public partial class Menu : Form {
        private NegocioMenu _negocio = new NegocioMenu();
        public Menu() {
            _negocio.StartConexion();
            InitializeComponent();
        }
        
        private void Boton_Cliente_Click(object sender, EventArgs e) {
            new Cliente().ShowDialog();
        }
    }
}