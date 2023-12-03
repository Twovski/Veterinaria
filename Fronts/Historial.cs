using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Fronts {
    public partial class Historial : Form {
        private NegocioDetalles _negocio = new NegocioDetalles();
        public EntidadVeterinario EVeterinario { get; set; }
        public EntidadPaciente EPaciente { get; set; }
        
        public Historial(EntidadVeterinario veterinario, EntidadPaciente paciente) {
            InitializeComponent();
            TablaHistorial.DataSource = _negocio.GetListado("SELECT * FROM VW_Historial");
            EPaciente = paciente;
            EVeterinario = veterinario;
            
            BoxPacID.DataSource = _negocio.ListaPaciente();
            if (paciente != null)
                BoxPacID.SelectedIndex = BoxPacID.FindStringExact(paciente.Nombre);
            BoxPacID.DisplayMember = "Nombre";
            BoxPacID.ValueMember = "PacID";

            BoxVetID.DataSource = _negocio.ListaVeterinaria();
            if (veterinario != null)
                BoxVetID.SelectedIndex = BoxVetID.FindStringExact(veterinario.Nombre);
            BoxVetID.DisplayMember = "Nombre";
            BoxVetID.ValueMember = "VetID";

            BoxServID.DataSource = _negocio.ListaServicio();
            BoxServID.DisplayMember = "Nombre";
            BoxServID.ValueMember = "ServID";
            
            TextTPID.Controls[0].Visible = false;
            TextTPID.Text = "";
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
            string[] columns = { "PacID", "VetID", "ServID", "Anotaciones", "Motivo" };    
            string query = "UPDATE Detalle ";
            string condition = "SET ";

            foreach (string column in columns) {
                string result = GetColumn(column);
                query += $"{condition} [{column}] = {IsNull(result)}";
                condition = ", ";
            }
            
            query += " WHERE TPacID = " + TextTPID.Text;
            return query;
        }
        
        private string QueryGuardar() {
            string[] columns = {  "PacID", "VetID", "ServID", "Anotaciones", "Motivo"  };
            string query = "INSERT INTO Detalle(";
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
            string[] columns = { "TPacID", "PacID", "VetID", "ServID", "Anotaciones", "Motivo" };
            string query = "SELECT * FROM VW_Historial";
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
                case "TPacID":
                    return TextTPID.Text;
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
                case "TPacID":
                    return LabelHistorial;
                case "Anotaciones":
                    return LabelAnotaciones;
                case "Motivo":
                    return LabelMotivo;
                case "PacID":
                    return LabelPaciente;
                case "ServID":
                    return LabelServicio;
                case "VetID":
                    return LabelVeterinario;
                default:
                    return null;
            }
        }

        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Consultar Historial";
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Historial";
        }

        private void OpcionE_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Editar Historial";
        }

        private void TablaHistorial_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;
            
            TablaHistorial.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaHistorial.Rows[e.RowIndex].Cells;
            TextTPID.Text = Column["TPacID"].Value.ToString().Trim();
            BoxVetID.Text = Column["Veterinario"].Value.ToString().Trim();
            BoxPacID.Text = Column["Paciente"].Value.ToString().Trim();
            BoxServID.Text = Column["Servicio"].Value.ToString().Trim();
            TextAnotaciones.Text = Column["Anotaciones"].Value.ToString().Trim();
            TextMotivo.Text = Column["Motivo"].Value.ToString().Trim();
        }

        private void BotonCliente_Click_1(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                TablaHistorial.DataSource = _negocio.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    string query = QueryGuardar();
                    _negocio.Execute(query);
                    TablaHistorial.DataSource = _negocio.GetListado("SELECT * FROM VW_Historial");
                    LabelCheck(new []{ "PacID", "VetID", "ServID", "Anotaciones", "Motivo" });
                }
                catch (Exception exception) {
                    LabelCheck(new []{ "PacID", "VetID", "ServID", "Anotaciones", "Motivo" });
                }
            }
            
            if (OpcionE.Checked) {
                try {
                    string query = QueryEditar();
                    _negocio.Execute(query);
                    TablaHistorial.DataSource = _negocio.GetListado("SELECT * FROM VW_Historial");
                    LabelCheck(new []{ "TPacID", "PacID", "VetID", "ServID", "Anotaciones", "Motivo" });
                }
                catch (Exception exception) {
                    Console.WriteLine(exception);
                    LabelCheck(new []{ "TPacID", "PacID", "VetID", "ServID", "Anotaciones", "Motivo" });
                }
            }
        }
    }
}