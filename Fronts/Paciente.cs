using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
    public partial class Paciente : Form {
        private NegocioPaciente _negocio = new NegocioPaciente();
        public EntidadPaciente EPaciente = null;
        public bool Consulta;

        public Paciente(bool consulta) {
            InitializeComponent();
            TablaPaciente.DataSource = _negocio.GetListado("SELECT * FROM VW_Paciente");
            TextPacID.Controls[0].Visible = false;
            TextEdad.Controls[0].Visible = false;
            
            BoxCliID.DataSource = _negocio.ListaCliente();
            BoxCliID.DisplayMember = "Nombre";
            BoxCliID.ValueMember = "CliID";
            
            BoxTipoID.DataSource = _negocio.ListaTipo();
            BoxTipoID.DisplayMember = "Nombre";
            BoxTipoID.ValueMember = "TipoID";

            List<EntidadSexo> list = new List<EntidadSexo>();
            list.Add(new EntidadSexo() {
                SexoID = ' ',
                Nombre = "Selecciona"
            });
            list.Add(new EntidadSexo() {
                SexoID = 'M',
                Nombre = "Masculino"
            });
            list.Add(new EntidadSexo() {
                SexoID = 'F',
                Nombre = "Femenino"
            });

            BoxSexo.DataSource = list;
            BoxSexo.DisplayMember = "Nombre";
            BoxSexo.ValueMember = "SexoID";
            
            TextPacID.Text = "";
            TextEdad.Text = "";

            Consulta = consulta;
            if (consulta) {
                OpcionB.Dispose();
                OpcionG.Dispose();
                OpcionE.Dispose();
                tableLayoutPanel3.SetRow(OpcionC, 0);
                tableLayoutPanel3.SetColumn(OpcionC, 4);
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
            return "UPDATE Paciente SET Status = 0 WHERE PacID = " + TextPacID.Text;
        }
        
        private string QueryEditar() {
            string[] columns = { "CliID", "TipoID", "Sexo", "Nombre", "Color" };
            string[] columnsN = { "Fecha Nacimiento", "Edad" };
            string query = "UPDATE Paciente ";
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
            
            query += " WHERE PacID = " + TextPacID.Text;
            return query;
        }
        
        private string QueryGuardar() {
            string[] columns = { "CliID", "TipoID", "Sexo", "Nombre", "Color", "Fecha Nacimiento", "Edad" };
            string query = "INSERT INTO Paciente(";
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
            string[] columns = { "CliID", "TipoID", "Sexo", "Nombre", "Color", "Fecha Nacimiento", "Edad", "PacID" };
            string query = "SELECT * FROM VW_Paciente";
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
            int id;
            switch (column) {
                case "PacID":
                    return TextPacID.Text;
                case "CliID":
                    id = (int) BoxCliID.SelectedValue;
                    return id == -1 ? "" : Convert.ToString(id);
                case "TipoID":
                    id = (int) BoxTipoID.SelectedValue;
                    return id == -1 ? "" : Convert.ToString(id);
                case "Sexo":
                    char value = (char) BoxSexo.SelectedValue;
                    return value == ' ' ? "" : Convert.ToString(value);
                case "Color":
                    return TextColor.Text;
                case "Fecha Nacimiento":
                    if (string.IsNullOrWhiteSpace(DateFN.Text))
                        return "";
                    
                    DateTime fecha = DateFN.Value;
                    return fecha.ToString("MM/dd/yyyy");
                case "Edad":
                    return TextEdad.Text;
                case "Nombre":
                    return TextNombre.Text;
                default:
                    return "";
            }
        }

        private Label GetLabel(string column) {
            switch (column) {
                case "PacID":
                    return LabelPacID;
                case "CliID":
                    return LabelCliente;
                case "TipoID":
                    return LabelTA;
                case "Sexo":
                    return LabelSexo;
                case "Nombre":
                    return LabelNombre;
                case "Color":
                    return LabelColor;
                default:
                    return null;
            }
        }
        
        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Buscar Paciente";
            TextPacID.ReadOnly = false;
            TextNombre.ReadOnly = false;
            TextEdad.ReadOnly = false;
            TextColor.ReadOnly = false;
            DateFN.Enabled = true;
            BoxSexo.Enabled = true;
            BoxCliID.Enabled = true;
            BoxTipoID.Enabled = true;
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Paciente";
            TextPacID.ReadOnly = true;
            TextNombre.ReadOnly = false;
            TextEdad.ReadOnly = false;
            TextColor.ReadOnly = false;
            DateFN.Enabled = true;
            BoxSexo.Enabled = true;
            BoxCliID.Enabled = true;
            BoxTipoID.Enabled = true;
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Paciente";
            TextPacID.ReadOnly = true;
            TextNombre.ReadOnly = true;
            TextEdad.ReadOnly = true;
            TextColor.ReadOnly = true;
            DateFN.Enabled = false;
            BoxSexo.Enabled = false;
            BoxCliID.Enabled = false;
            BoxTipoID.Enabled = false;
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Paciente";
            TextPacID.ReadOnly = true;
            TextNombre.ReadOnly = false;
            TextEdad.ReadOnly = false;
            TextColor.ReadOnly = false;
            DateFN.Enabled = true;
            BoxSexo.Enabled = true;
            BoxCliID.Enabled = true;
            BoxTipoID.Enabled = true;
        }

        private void TablaPaciente_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;
            
            TablaPaciente.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaPaciente.Rows[e.RowIndex].Cells;
            string pacID = Column["PacID"].Value.ToString().Trim();
            string fecha = Column["Fecha Nacimiento"].Value.ToString().Trim();
            if (Consulta) {
                string query = $"SELECT * FROM VW_Paciente WHERE PacID = {pacID}";
                EPaciente = _negocio.GetPaciente(query);
                Close();
            }
            
            TextPacID.Text = pacID;
            TextNombre.Text = Column["Nombre"].Value.ToString().Trim();
            BoxTipoID.Text = Column["Tipo Animal"].Value.ToString().Trim();
            
            BoxSexo.Text = GetSexo(Column["Sexo"].Value.ToString().Trim());
            TextColor.Text = Column["Color"].Value.ToString().Trim();
            BoxCliID.Text = Column["Cliente"].Value.ToString().Trim();
            if (!string.IsNullOrWhiteSpace(fecha)) {
                DateFN.Format = DateTimePickerFormat.Long;
                DateFN.Value = DateTime.Parse(fecha);
            }
            else {
                DateFN.Format = DateTimePickerFormat.Custom;
                DateFN.CustomFormat = " ";
            }
            TextEdad.Text = Column["Edad"].Value.ToString().Trim();
        }

        private string GetSexo(string value) {
            return value.Equals("M")  ? "Masculino" : "Femenino";
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                TablaPaciente.DataSource = _negocio.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    LabelCheck(new []{ "TipoID", "Sexo", "Nombre", "Color", "CliID" });
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaPaciente.DataSource = _negocio.GetListado("SELECT * FROM VW_Paciente");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Guardado Exitosamente", "Crear Paciente" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    LabelCheck(new []{ "PacID", "TipoID", "Sexo", "Nombre", "Color", "CliID" });
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaPaciente.DataSource = _negocio.GetListado("SELECT * FROM VW_Paciente");
                    MessageBox.Show("Editado Exitosamente", "Editar Paciente" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    LabelCheck(new []{ "PacID" });
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaPaciente.DataSource = _negocio.GetListado("SELECT * FROM VW_Paciente");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Eliminado Exitosamente", "Eliminar Paciente" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException exception) {
                    Console.WriteLine("Error SQL Server {0}: {1}", exception.Number, exception.Message);
                }
            }
        }
        private void DateFN_ValueChanged_1(object sender, EventArgs e) {
            DateFN.Format = DateTimePickerFormat.Long;
        }

        private void BotonLimpiar_Click(object sender, EventArgs e) {
            TextPacID.Text = "";
            TextNombre.Clear();
            TextEdad.Text = "";
            TextColor.Clear();
            DateFN.Format = DateTimePickerFormat.Custom;
            DateFN.CustomFormat = " ";
            BoxSexo.Text = "Selecciona";
            BoxCliID.Text = "Selecciona";
            BoxTipoID.Text = "Selecciona";
        }
    }
}