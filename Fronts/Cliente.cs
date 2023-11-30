using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
    public partial class Cliente : Form {
        private NegocioCliente _negocio = new NegocioCliente();
        
        public Cliente() {
            InitializeComponent();
            TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM Cliente");
            /*
            List<EntidadCliente> list = table.AsEnumerable().Select(data => new EntidadCliente() {
                ID = data.Field<int>("ID"),
                Nombre = data.Field<string>("Nombre"),
                ApellidoPaterno = data.Field<string>("Apellido Paterno"),
                ApellidoMaterno = data.Field<string>("Apellido Materno"),
                IFE = data.Field<string>("IFE"),
                Direccion = data.Field<string>("Direccion"),
                Correo = data.Field<string>("Correo"),
                Celular = data.Field<string>("Celular"),
                Telefono = data.Field<string>("Telefono"),
                Veterinario = data.Field<int>("VetID")
            }).ToList();
            */
        }


        private void BotonCliente_Click(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryCliente();
                TablaCliente.DataSource = _negocio.GetListado(query);
            }
            else if (OpcionG.Checked) {
                
            }
            else if (OpcionE.Checked) {
                
            }
            else if (OpcionB.Checked) {
                
            }
                
        }

        private string QueryCliente() {
            string query = "SELECT * FROM Cliente";
            string condition = "WHERE";

            if (!string.IsNullOrWhiteSpace(TextCliID.Text)) {
                query += condition + " clieID = " + TextCliID.Text;
                condition = "AND";
            }
            
            //Hacer cambios
            if (!string.IsNullOrWhiteSpace(BoxVetID.SelectedText)) {
                query += condition + " vetID = " + BoxVetID.SelectedText;
                condition = "AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextNombre.Text)) {
                query += condition + " clieNombre = " + TextNombre.Text;
                condition = "AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextIFE.Text)) {
                query += condition + " clieIFE = " + TextIFE.Text;
                condition = "AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextAP.Text)) {
                query += condition + " clieApellidoPat = " + TextAP.Text;
                condition = "AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextAM.Text)) {
                query += condition + " clieApellidoMat = " + TextAM.Text;
                condition = "AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextDireccion.Text)) {
                query += condition + " clieDireccion = " + TextDireccion.Text;
                condition = "AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextCorreo.Text)) {
                query += condition + " clieCorreo = " + TextCorreo.Text;
                condition = "AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextCelular.Text)) {
                query += condition + " clieCelular = " + TextCelular.Text;
                condition = "AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextDireccion.Text)) {
                query += condition + " clieTelefono = " + TextDireccion.Text;
            }
            
            return query;
        }
        
    }
}