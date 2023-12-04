using System;
using System.Drawing;
using System.Windows.Forms;
using Negocio;

namespace Fronts {
    public partial class Desparasitante : Form {
        private NegocioCitaDetalle _negocioCitaDetalle = new NegocioCitaDetalle();
        private NegocioCita _negocioCita = new NegocioCita();
        public Desparasitante() {
            InitializeComponent();
            TablaVacunas.DataSource = _negocioCitaDetalle.GetListado("SELECT * FROM VW_Desparasitante");
            TablaCitas.DataSource = _negocioCita.GetListado("SELECT * FROM VW_Cita");
            BoxTraID.DataSource = _negocioCitaDetalle.ListaDesparasitante();
            BoxTraID.DisplayMember = "Nombre";
            BoxTraID.ValueMember = "TraID";
        }
        
        private string IsNull(string text) {
            return string.IsNullOrWhiteSpace(text) ? "null" : "'" + text + "'";
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
        
        private string QueryGuardar() {
            string[] columns = {  "TraID", "CitaID", "Fecha Proxima", "Cantidad"  };
            string query = "INSERT INTO CitaDetalle(";
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
            string[] columns = { "TraID", "CitaID", "Fecha Proximo", "Cantidad" };
            string query = "SELECT * FROM VW_Desparasitante";
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
        
        private string GetColumn(string column) {
            int id;
            switch (column) {
                case "TraID":
                    id = (int) BoxTraID.SelectedValue;
                    return id == -1 ? "" : Convert.ToString(id);
                case "CitaID":
                    return TextCita.Text;
                case "Cantidad":
                    return TextCantidad.Text;
                case "Fecha Proxima":
                    if (string.IsNullOrWhiteSpace(DateFP.Text))
                        return "";
                    DateTime fecha = DateFP.Value;
                    return fecha.ToString();
                default:
                    return "";
            }
        }

        private Label GetLabel(string column) {
            switch (column) {
                case "TraID":
                    return LabelTratamiento;
                case "CitaID":
                    return LabelCita;
                case "Cantidad":
                    return LabelCantidad;
                case "Fecha Proxima":
                    return LabelFP;
                default:
                    return null;
            }
        }
        private void OpcionC_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Buscar Desparasitante";
        }

        private void OpcionG_CheckedChanged(object sender, EventArgs e) {
            Titulo.Text = "Crear Desparasitante";
        }

        private void TablaVacunas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;
            
            TablaVacunas.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaVacunas.Rows[e.RowIndex].Cells;
            string fecha = Column["Fecha Proxima"].Value.ToString().Trim();
            
            BoxTraID.Text = Column["Desparasitante"].Value.ToString().Trim();
            TextCantidad.Text = Column["Cantidad"].Value.ToString().Trim();
            TextCita.Text = Column["CitaID"].Value.ToString().Trim();
            
            if (!string.IsNullOrWhiteSpace(fecha))
                DateFP.Text = fecha;
            else {
                DateFP.Format = DateTimePickerFormat.Custom;
                DateFP.CustomFormat = " ";
            }

        }

        private void DateFP_ValueChanged(object sender, EventArgs e) {
            DateFP.Format = DateTimePickerFormat.Long;
        }

        private void BotonCliente_Click(object sender, EventArgs e) {
            if (OpcionC.Checked) {
                string query = QueryConsulta();
                Console.WriteLine(query);
                TablaVacunas.DataSource = _negocioCitaDetalle.GetListado(query);
            }
            
            if (OpcionG.Checked) {
                try {
                    LabelCheck(new []{ "TraID", "CitaID", "Fecha Proxima", "Cantidad" });
                    string query = QueryGuardar();
                    Console.WriteLine(query);
                    _negocioCitaDetalle.Execute(query);
                    TablaVacunas.DataSource = _negocioCitaDetalle.GetListado("SELECT * FROM VW_Desparasitante");
                    BotonLimpiar.PerformClick();
                }
                catch (Exception exception) {
                    
                }
            }
        }


        private void TablaCitas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;
            
            TablaCitas.CurrentRow.Selected = true;
            DataGridViewCellCollection Column = TablaCitas.Rows[e.RowIndex].Cells;
            TextCita.Text = Column["CitaID"].Value.ToString().Trim();

        }

        private void BotonLimpiar_Click(object sender, EventArgs e) {
            TextCita.Text = "";
            TextCantidad.Value = 0;
            BoxTraID.Text = "Selecciona";
            DateFP.Format = DateTimePickerFormat.Custom;
            DateFP.CustomFormat = " ";
        }
    }
}