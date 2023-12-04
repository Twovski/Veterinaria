using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
    public partial class Consultas : Form {
        private NegocioCita _negocio = new NegocioCita();
        public EntidadVeterinario EVeterinario { get; set; }
        public EntidadPaciente EPaciente { get; set; }
        
        public Consultas(EntidadVeterinario veterinario, EntidadPaciente paciente) {
            InitializeComponent();
            TablaConsulta.DataSource = _negocio.GetListado("SELECT * FROM VW_Cita");
            EPaciente = paciente;
            EVeterinario = veterinario;
            
            BoxVetID.DataSource = _negocio.ListaVeterinaria(veterinario);
            BoxVetID.DisplayMember = "Nombre";
            BoxVetID.ValueMember = "VetID";
            BoxVetID.Text = veterinario.Nombre;
            
            BoxPacID.DataSource = _negocio.ListaPaciente(paciente);
            if (paciente != null)
                BoxPacID.Text = paciente.Nombre;
            BoxPacID.DisplayMember = "Nombre";
            BoxPacID.ValueMember = "PacID";

            BoxServID.DataSource = _negocio.ListaServicio();
            BoxServID.DisplayMember = "Nombre";
            BoxServID.ValueMember = "ServID";
            
            TextCitaID.Controls[0].Visible = false;
            TextCitaID.Text = "";
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
        
        private string QueryEditar() {
            string[] columns = { "Anotaciones", "Motivo" };    
            string query = "UPDATE Cita ";
            string condition = "SET ";

            foreach (string column in columns) {
                string result = GetColumn(column);
                query += $"{condition} [{column}] = {IsNull(result)}";
                condition = ", ";
            }
            
            query += " WHERE CitaID = " + TextCitaID.Text;
            return query;
        }
        
        private string QueryGuardar() {
            string[] columns = { "VetID", "ServID", "PacID", "Anotaciones", "Motivo" };
            string query = "INSERT INTO Cita(";
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
            string[] columns = { "CitaID", "PacID", "VetID", "ServID", "Anotaciones", "Motivo" };
            string query = "SELECT * FROM VW_Cita";
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
                case "CitaID":
                    return TextCitaID.Text;
                case "Anotaciones":
                    return TextAnotaciones.Text;
                case "Motivo":
                    return TextMotivo.Text;
                case "PacID":
                    id = (int) BoxPacID.SelectedValue;
                    return id == -1 ? "" : Convert.ToString(id);
                case "ServID":
                    id = (int) BoxServID.SelectedValue;
                    return id == -1 ? "" : Convert.ToString(id);
                case "VetID":
                    id = (int) BoxVetID.SelectedValue;
                    return id == -1 ? "" : Convert.ToString(id);
                default:
                    return "";
            }
        }

        private Label GetLabel(string column) {
            switch (column) {
                case "CitaID":
                    return LabelCita;
                case "Anotaciones":
                    return LabelAnotaciones;
                case "Motivo":
                    return LabelMotivo;
                case "PacID":
                    return LabelPaciente;
                case "ServID":
                    return LabelServicio;
                case "VetID":
                    return LabelVet;
                default:
                    return null;
            }
        }

        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Buscar Consulta";
            TextCitaID.ReadOnly = false;
            BoxPacID.Enabled = true;
            BoxVetID.Enabled = true;
            BoxServID.Enabled = true;
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Consulta";
            TextCitaID.ReadOnly = true;
            BoxPacID.Enabled = true;
            BoxVetID.Enabled = true;
            BoxServID.Enabled = true;
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Consulta";
            TextCitaID.ReadOnly = true;
            BoxPacID.Enabled = false;
            BoxVetID.Enabled = false;
            BoxServID.Enabled = false;
        }

        private void TablaHistorial_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;
            
            TablaConsulta.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaConsulta.Rows[e.RowIndex].Cells;
            TextCitaID.Text = Column["CitaID"].Value.ToString().Trim();
            BoxVetID.Text = Column["Veterinario"].Value.ToString().Trim();
            BoxPacID.Text = Column["Paciente"].Value.ToString().Trim();
            BoxServID.Text = Column["Servicio"].Value.ToString().Trim();
            TextAnotaciones.Text = Column["Anotaciones"].Value.ToString().Trim();
            TextMotivo.Text = Column["Motivo"].Value.ToString().Trim();
        }

        private void BotonCliente_Click_1(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                TablaConsulta.DataSource = _negocio.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    LabelCheck(new []{ "PacID", "VetID", "ServID", "Anotaciones", "Motivo" });
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaConsulta.DataSource = _negocio.GetListado("SELECT * FROM VW_Cita");
                    BotonLimpiar.PerformClick();
                    MessageBox.Show("Guardado Exitosamente", "Crear Consulta" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception) {
                    
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    LabelCheck(new []{ "CitaID", "Anotaciones", "Motivo" });
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaConsulta.DataSource = _negocio.GetListado("SELECT * FROM VW_Cita");
                    MessageBox.Show("Editado Exitosamente", "Editar Consulta" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception) {
                    
                }
            }
        }

        private void BotonLimpiar_Click(object sender, EventArgs e) {
            TextCitaID.Text = "";
            BoxVetID.Text = "Selecciona";
            BoxPacID.Text = "Selecciona";
            BoxServID.Text = "Selecciona";
            TextMotivo.Clear();
            TextAnotaciones.Clear();
        }
    }
}