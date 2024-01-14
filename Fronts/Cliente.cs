using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
     public partial class Cliente : Form {
        private NegocioCliente _negocio = new NegocioCliente();
        
        public Cliente(string text) {
            InitializeComponent();
            TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM VW_Cliente");
            TextCliID.Controls[0].Visible = false;
            BoxVetID.DataSource = _negocio.ListaVeterinaria();
            BoxVetID.DisplayMember = "Nombre";
            BoxVetID.ValueMember = "VetID";
            BoxVetID.Text = text;
            TextCliID.Text = "";
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                TablaCliente.DataSource = _negocio.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    LabelCheck(new []{ "Nombre", "IFE", "Apellido Paterno", "Apellido Materno", "Direccion", "VetID" });
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM VW_Cliente");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Guardado Exitosamente", "Crear Cliente" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    if (exception.Number == 2627) 
                        MessageBox.Show("No se pueden repetir los datos de estos campos(IFE, Correo, Telefono, Celular)", 
                            "Advertencia" , 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning);
                    else
                        Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    LabelCheck(new []{ "CliID", "Nombre", "IFE", "Apellido Paterno", "Apellido Materno", "Direccion", "VetID" });
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM VW_Cliente");
                    MessageBox.Show("Editado Exitosamente", "Editar Cliente" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    if (exception.Number == 2627) 
                        MessageBox.Show("No se pueden repetir los datos de estos campos(IFE, Correo, Telefono, Celular)", 
                            "Advertencia" , 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning);
                    else
                        Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    LabelCheck(new []{ "CliID" });
                    string query = QueryBaja();
                    int row = _negocio.Execute(query);
                    Console.WriteLine(row);
                    TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM VW_Cliente");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Eliminado Exitosamente", "Eliminar Cliente" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
        }

        private void LabelCheck(string[] columns) {
            foreach (string column in columns) {
                string text = GetColumn(column);
                if (string.IsNullOrWhiteSpace(text)) 
                    GetLabel(column).ForeColor = Color.Red;
                else 
                    GetLabel(column).ForeColor = Color.Black;
            }
        }

        private string QueryBaja() {
            return "UPDATE Cliente SET Status = 0 WHERE CliID = " + TextCliID.Text;
        }
        
        private string QueryEditar() {
            string[] columns = {  "Nombre", "Apellido Paterno", "Apellido Materno", "Direccion", "IFE", "VetID" };
            string[] columnsN = { "Correo", "Celular", "Telefono" };
            string query = "UPDATE Cliente ";
            string condition = "SET ";

            foreach (string column in columnsN) {
                string result = GetColumn(column);
                query += $"{condition} [{column}] = {IsNull(result)}";
                condition = ", ";
            }
            
            foreach (string column in columns) {
                string result = GetColumn(column);
                if (!string.IsNullOrWhiteSpace(result)) {
                    query += $"{condition} [{column}] = {IsNull(result)}";
                    condition = ", ";
                }
            }
            
            query += " WHERE CliID = " + TextCliID.Text;
            return query;
        }
        
        private string QueryGuardar() {
            string[] columns = {  "Nombre", "Apellido Paterno", "Apellido Materno", "Direccion", "IFE", "Correo", "Celular", "Telefono", "VetID" };
            string query = "INSERT INTO Cliente(";
            query += "[" + string.Join("], [", columns) + "]";
            query += ") VALUES (";
            
            foreach (string column in columns) {
                string result = GetColumn(column);
                query += $"{IsNull(result)}, ";
            }
            
            query = query.TrimEnd(' ', ',') + ")";
            return query;
        }

        private string QueryConsulta() {
            string[] columns = { "CliID", "VetID", "Nombre", "IFE", "Apellido Paterno", "Apellido Materno", "Direccion", "Correo", "Celular", "Telefono" };
            string query = "SELECT * FROM VW_Cliente";
            string condition = " WHERE";

            foreach (string column in columns) {
                string result = GetColumn(column);
                if (!string.IsNullOrWhiteSpace(result)) {
                    query += condition + $" [{column}] = '{result}'";
                    condition = " AND";
                }
            }
            
            return query;
        }
        
        private string IsNull(string text) {
            return string.IsNullOrWhiteSpace(text) ? "null" : "'" + text + "'";
        }
        
        private string GetColumn(string column) {
            switch (column) {
                case "CliID":
                    return TextCliID.Text;
                case "VetID":
                    int id = (int) BoxVetID.SelectedValue;
                    return id == -1 ? "" : Convert.ToString(BoxVetID.SelectedValue);
                case "Nombre":
                    return TextNombre.Text;
                case "IFE":
                    return TextIFE.Text;
                case "Apellido Paterno":
                    return TextAP.Text;
                case "Apellido Materno":
                    return TextAM.Text;
                case "Direccion":
                    return TextDireccion.Text;
                case "Correo":
                    return TextCorreo.Text;
                case "Celular":
                    return TextCelular.Text;
                case "Telefono":
                    return TextTelefono.Text;
                default:
                    return "";
            }
        }

        private Label GetLabel(string column) {
            switch (column) {
                case "CliID":
                    return LabelCliID;
                case "VetID":
                    return LabelVetID;
                case "Nombre":
                    return LabelNombre;
                case "IFE":
                    return LabelIFE;
                case "Apellido Paterno":
                    return LabelAP;
                case "Apellido Materno":
                    return LabelAM;
                case "Direccion":
                    return LabelDireccion;
                default:
                    return null;
            }
        }
        
        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Buscar Clientes";
            TextCliID.ReadOnly = false;
            BoxVetID.Enabled = true;
            TextNombre.ReadOnly = false;
            TextAP.ReadOnly = false;
            TextAM.ReadOnly = false;
            TextIFE.ReadOnly = false;
            TextCorreo.ReadOnly = false;
            TextDireccion.ReadOnly = false;
            TextTelefono.ReadOnly = false;
            TextCelular.ReadOnly = false;
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Clientes";
            TextCliID.ReadOnly = true;
            BoxVetID.Enabled = true;
            TextNombre.ReadOnly = false;
            TextAP.ReadOnly = false;
            TextAM.ReadOnly = false;
            TextIFE.ReadOnly = false;
            TextCorreo.ReadOnly = false;
            TextDireccion.ReadOnly = false;
            TextTelefono.ReadOnly = false;
            TextCelular.ReadOnly = false;
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Clientes";
            TextCliID.ReadOnly = true;
            BoxVetID.Enabled = false;
            TextNombre.ReadOnly = true;
            TextAP.ReadOnly = true;
            TextAM.ReadOnly = true;
            TextIFE.ReadOnly = true;
            TextCorreo.ReadOnly = true;
            TextDireccion.ReadOnly = true;
            TextTelefono.ReadOnly = true;
            TextCelular.ReadOnly = true;
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Clientes";
            TextCliID.ReadOnly = true;
            BoxVetID.Enabled = true;
            TextNombre.ReadOnly = false;
            TextAP.ReadOnly = false;
            TextAM.ReadOnly = false;
            TextIFE.ReadOnly = false;
            TextCorreo.ReadOnly = false;
            TextDireccion.ReadOnly = false;
            TextTelefono.ReadOnly = false;
            TextCelular.ReadOnly = false;
        }

        private void TablaCliente_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;
            
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

        private void BotonLimpiar_Click(object sender, EventArgs e) {
            TextCliID.Text = "";
            BoxVetID.Text = "Selecciona";
            TextNombre.Clear();
            TextAP.Clear();
            TextAM.Clear();
            TextIFE.Clear();
            TextCorreo.Clear();
            TextDireccion.Clear();
            TextTelefono.Clear();
            TextCelular.Clear();
        }
     }
}