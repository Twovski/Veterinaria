using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
    public partial class Paciente : Form {
        private NegocioPaciente _negocio = new NegocioPaciente();

        public Paciente() {
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
                SexoID = -1,
                Nombre = "Selecciona"
            });
            list.Add(new EntidadSexo() {
                SexoID = 1,
                Nombre = "Masculino"
            });
            list.Add(new EntidadSexo() {
                SexoID = 0,
                Nombre = "Femenino"
            });

            BoxSexo.DataSource = list;
            BoxSexo.DisplayMember = "Nombre";
            BoxSexo.ValueMember = "SexoID";
            
            TextPacID.Text = "";
            TextEdad.Text = "";
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
            string[] columns = { "CliID", "TipoID", "Sexo", "Nombre", "Color", "Fecha Nacimiento", "Edad" };
            string query = "UPDATE Paciente ";
            string condition = "SET ";

            foreach (string column in columns) {
                string result = GetColumn(column);
                query += $"{condition} [{column}] = {IsNull(result)}";
                condition = ", ";
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
                    id = (int) BoxSexo.SelectedValue;
                    return id == -1 ? "" : Convert.ToString(id);
                case "Color":
                    return TextColor.Text;
                case "Fecha Nacimiento":
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
                    return LabelRaza;
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

        private void TextEdad_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '-') 
                e.Handled = true;
        }
        
        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Consultar Paciente";
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Paciente";
        }

        private void OpcionB_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Eliminar Paciente";
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Paciente";
        }

        private void TablaPaciente_CellClick(object sender, DataGridViewCellEventArgs e) {
            TablaPaciente.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaPaciente.Rows[e.RowIndex].Cells;
            TextPacID.Text = Column["PacID"].Value.ToString().Trim();
            TextNombre.Text = Column["Nombre"].Value.ToString().Trim();
            BoxTipoID.Text = Column["Raza"].Value.ToString().Trim();
            BoxSexo.Text = GetSexo((bool) Column["Sexo"].Value);
            TextColor.Text = Column["Color"].Value.ToString().Trim();
            BoxCliID.Text = Column["Cliente"].Value.ToString().Trim();
            DateFN.Value = DateTime.Parse(Column["Fecha Nacimiento"].Value.ToString().Trim());
            TextEdad.Text = Column["Edad"].Value.ToString().Trim();
        }

        private string GetSexo(bool value) {
            return value ? "Masculino" : "Femenino";
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                TablaPaciente.DataSource = _negocio.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaPaciente.DataSource = _negocio.GetListado("SELECT * FROM VW_Paciente");
                    LabelCheck(new []{ "PacID", "TipoID", "Sexo", "Nombre", "Color" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "PacID", "TipoID", "Sexo", "Nombre", "Color" });
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaPaciente.DataSource = _negocio.GetListado("SELECT * FROM VW_Paciente");
                    LabelCheck(new []{ "PacID", "TipoID", "Sexo", "Nombre", "Color" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "PacID", "TipoID", "Sexo", "Nombre", "Color" });
                    
                }
            }
            
            if (OpcionB.Checked) {
                try {
                    string query = QueryBaja();
                    _negocio.Execute(query);
                    TablaPaciente.DataSource = _negocio.GetListado("SELECT * FROM VW_Paciente");
                    LabelCheck(new []{ "PacID" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "PacID" });
                }
            }
        }
    }
}