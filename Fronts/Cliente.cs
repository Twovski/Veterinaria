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
            TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM VW_Cliente");
            TextCliID.Controls[0].Visible = false;
            BoxVetID.DataSource = _negocio.ListaVeterinaria();
            BoxVetID.DisplayMember = "Nombre";
            BoxVetID.ValueMember = "VetID";
            TextCliID.Text = "";
        }


        private void BotonCliente_Click(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                TablaCliente.DataSource = _negocio.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM VW_Cliente");
                }
                catch (Exception exception) {
                    MessageBox.Show("Porfavor rellenar los campos necesarios (*)");
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM VW_Cliente");
                }
                catch (Exception exception) {
                    MessageBox.Show("Porfavor selecciona algun registro de la tabla dando click");
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM VW_Cliente");
                }
                catch (Exception exception) {
                    MessageBox.Show("Porfavor selecciona algun registro de la tabla dando click");
                }
            }
                
        }

        private string IsNull(string text) {
            return string.IsNullOrWhiteSpace(text) ? "null" : "'" + text + "'";
        }

        private string QueryBaja() {
            string query = "UPDATE Cliente SET ";
            query += " Status = 0";
            query += " WHERE CliID = " + TextCliID.Text;
            return query;
        }
        
        private string QueryEditar() {
            string query = "UPDATE Cliente ";
            string condition = "SET ";
            
            if (BoxVetID.SelectedIndex != 0) {
                EntidadVeterinaria item = (EntidadVeterinaria) BoxVetID.SelectedItem;
                query +=  condition + " VetID = " + item.VetID;
                condition = ",";
            }

            if (!string.IsNullOrWhiteSpace(TextNombre.Text)) {
                query += condition + " Nombre = '" + TextNombre.Text + "'";
                condition = ",";
            }

            if (!string.IsNullOrWhiteSpace(TextIFE.Text)) {
                query += condition + " IFE = '" + TextIFE.Text + "'";
                condition = ",";
            }

            if (!string.IsNullOrWhiteSpace(TextAP.Text)) {
                query +=  condition + " \"Apellido Paterno\" = '" + TextAP.Text + "'";
                condition = ",";
            }

            if (!string.IsNullOrWhiteSpace(TextAM.Text)) {
                query +=  condition + " \"Apellido Materno\" = '" + TextAM.Text + "'";
                condition = ",";
            }


            if (!string.IsNullOrWhiteSpace(TextDireccion.Text)) {
                query += condition + " Direccion = '" + TextDireccion.Text + "'";
                condition = ",";
            }
            
            if (!string.IsNullOrWhiteSpace(TextCorreo.Text)) {
                query += condition + " Correo = '" + TextCorreo.Text + "'";
                condition = ",";
            }
            
            if (!string.IsNullOrWhiteSpace(TextCelular.Text)) {
                query += condition + " Celular = '" + TextCelular.Text + "'";
                condition = ",";
            }
            
            if (!string.IsNullOrWhiteSpace(TextDireccion.Text)) {
                query += condition + " Telefono = '" + TextDireccion.Text + "'";
            }

            query += " WHERE CliID = " + TextCliID.Text;
            
            return query;
        }
        
        private string QueryGuardar() {
            EntidadVeterinaria veterinario = (EntidadVeterinaria) BoxVetID.SelectedItem;
            string query = "INSERT INTO Cliente VALUES (";
            query += IsNull(TextNombre.Text) + ", ";
            query += IsNull(TextAP.Text) + ", ";
            query += IsNull(TextAM.Text) + ", ";
            query += IsNull(TextDireccion.Text) + ", ";
            query += IsNull(TextIFE.Text) + ", ";
            query += "1, ";
            query += IsNull(TextCorreo.Text) + ", ";
            query += IsNull(TextTelefono.Text) + ", ";
            query += IsNull(TextCelular.Text) + ", ";
            query += veterinario.VetID + ")";
            return query;
        }

        private string QueryConsulta() {
            string query = "SELECT * FROM VW_Cliente";
            string condition = " WHERE";

            if (!string.IsNullOrWhiteSpace(TextCliID.Text)) {
                query += condition + " CliID = " + TextCliID.Text;
                condition = " AND";
            }
            
            if (BoxVetID.SelectedIndex != 0) {
                EntidadVeterinaria item = (EntidadVeterinaria) BoxVetID.SelectedItem;
                query += condition + " VetID = " + item.VetID;
                condition = " AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextNombre.Text)) {
                query += condition + " Nombre = '" + TextNombre.Text + "'";
                condition = " AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextIFE.Text)) {
                query += condition + " IFE = '" + TextIFE.Text + "'";
                condition = " AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextAP.Text)) {
                query += condition + " \"Apellido Paterno\" = '" + TextAP.Text + "'";
                condition = " AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextAM.Text)) {
                query += condition + " \"Apellido Materno\" = '" + TextAM.Text + "'";
                condition = " AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextDireccion.Text)) {
                query += condition + " Direccion = '" + TextDireccion.Text + "'";
                condition = " AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextCorreo.Text)) {
                query += condition + " Correo = '" + TextCorreo.Text + "'";
                condition = " AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextCelular.Text)) {
                query += condition + " Celular = '" + TextCelular.Text + "'";
                condition = " AND";
            }
            
            if (!string.IsNullOrWhiteSpace(TextDireccion.Text)) {
                query += condition + " Telefono = '" + TextDireccion.Text + "'";
            }
            
            return query;
        }

        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Consultar Clientes";
            TextCliID.Enabled = true;
            TextNombre.Enabled = true;
            TextAP.Enabled = true;
            TextAM.Enabled = true;
            TextDireccion.Enabled = true;
            TextCorreo.Enabled = true;
            TextIFE.Enabled = true;
            TextCelular.Enabled = true;
            TextTelefono.Enabled = true;
            BoxVetID.Enabled = true;
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Clientes";
            TextCliID.Enabled = false;
            TextNombre.Enabled = true;
            TextAP.Enabled = true;
            TextAM.Enabled = true;
            TextDireccion.Enabled = true;
            TextCorreo.Enabled = true;
            TextIFE.Enabled = true;
            TextCelular.Enabled = true;
            TextTelefono.Enabled = true;
            BoxVetID.Enabled = true;
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Clientes";
            TextCliID.Enabled = false;
            TextNombre.Enabled = false;
            TextAP.Enabled = false;
            TextAM.Enabled = false;
            TextDireccion.Enabled = false;
            TextCorreo.Enabled = false;
            TextIFE.Enabled = false;
            TextCelular.Enabled = false;
            TextTelefono.Enabled = false;
            BoxVetID.Enabled = false;
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Clientes";
            TextCliID.Enabled = false;
            TextNombre.Enabled = true;
            TextAP.Enabled = true;
            TextAM.Enabled = true;
            TextDireccion.Enabled = true;
            TextCorreo.Enabled = true;
            TextIFE.Enabled = true;
            TextCelular.Enabled = true;
            TextTelefono.Enabled = true;
            BoxVetID.Enabled = true;
        }

        private void TablaCliente_CellClick(object sender, DataGridViewCellEventArgs e) {
            TablaCliente.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaCliente.Rows[e.RowIndex].Cells;
            TextCliID.Text = Column["CliID"].Value.ToString().Trim();
            TextNombre.Text = Column["Nombre"].Value.ToString().Trim();
            TextAP.Text = Column["Apellido Paterno"].Value.ToString().Trim();
            TextAM.Text = Column["Apellido Materno"].Value.ToString().Trim();
            TextDireccion.Text = Column["Direccion"].Value.ToString().Trim();
            TextCorreo.Text = Column["Correo"].Value.ToString().Trim();
            TextIFE.Text = Column["IFE"].Value.ToString().Trim();
            TextCelular.Text = Column["Celular"].Value.ToString();
            TextTelefono.Text = Column["Telefono"].Value.ToString();
            BoxVetID.Text = Column["Veterinaria"].Value.ToString();
        }
    }
}