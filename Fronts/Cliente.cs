using System;
using System.Drawing;
using System.Windows.Forms;
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
                    LabelCheck(new []{ "Nombre", "IFE", "Apellido Paterno", "Apellido Materno", "Direccion", "VetID" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "Nombre", "IFE", "Apellido Paterno", "Apellido Materno", "Direccion", "VetID" });
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM VW_Cliente");
                    LabelCheck(new []{ "CliID", "Nombre", "IFE", "Apellido Paterno", "Apellido Materno", "Direccion", "VetID" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "CliID", "Nombre", "IFE", "Apellido Paterno", "Apellido Materno", "Direccion", "VetID" });
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaCliente.DataSource = _negocio.GetListado("SELECT * FROM VW_Cliente");
                    LabelCheck(new []{ "CliID" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "CliID" });
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
            string[] columns = {  "Nombre", "Apellido Paterno", "Apellido Materno", "Direccion", "IFE", "Correo", "Celular", "Telefono", "VetID" };
            string query = "UPDATE Cliente ";
            string condition = "SET ";

            foreach (string column in columns) {
                string result = GetColumn(column);
                query += $"{condition} [{column}] = {IsNull(result)}";
                condition = ", ";
            }
            
            query += " WHERE CliID = " + TextCliID.Text;
            
            Console.WriteLine(query);
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
            Titulo.Text = "Consultar Clientes";
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Clientes";
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Clientes";
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Clientes";
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