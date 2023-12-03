using System.ComponentModel;

namespace Fronts {
    partial class Historial {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TextTPID = new System.Windows.Forms.NumericUpDown();
            this.LabelHistorial = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.BotonCliente = new System.Windows.Forms.Button();
            this.LabelAnotaciones = new System.Windows.Forms.Label();
            this.LabelMotivo = new System.Windows.Forms.Label();
            this.TextAnotaciones = new System.Windows.Forms.TextBox();
            this.TextMotivo = new System.Windows.Forms.TextBox();
            this.BoxServID = new System.Windows.Forms.ComboBox();
            this.LabelServicio = new System.Windows.Forms.Label();
            this.BoxPacID = new System.Windows.Forms.ComboBox();
            this.LabelPaciente = new System.Windows.Forms.Label();
            this.LabelVeterinario = new System.Windows.Forms.Label();
            this.BoxVetID = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.OpcionG = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpcionE = new System.Windows.Forms.RadioButton();
            this.OpcionC = new System.Windows.Forms.RadioButton();
            this.TablaHistorial = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextTPID)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 30);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 30);
            this.panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TablaHistorial, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 456);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(446, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(437, 450);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.TextTPID, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.LabelHistorial, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Titulo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BotonCliente, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.LabelAnotaciones, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.LabelMotivo, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.TextAnotaciones, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.TextMotivo, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.BoxServID, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.LabelServicio, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.BoxPacID, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.LabelPaciente, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.LabelVeterinario, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.BoxVetID, 2, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 12;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(431, 354);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // TextTPID
            // 
            this.TextTPID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextTPID, 2);
            this.TextTPID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTPID.Location = new System.Drawing.Point(3, 90);
            this.TextTPID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.TextTPID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.TextTPID.Name = "TextTPID";
            this.TextTPID.Size = new System.Drawing.Size(208, 21);
            this.TextTPID.TabIndex = 47;
            this.TextTPID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LabelHistorial
            // 
            this.LabelHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelHistorial, 2);
            this.LabelHistorial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHistorial.Location = new System.Drawing.Point(3, 58);
            this.LabelHistorial.Name = "LabelHistorial";
            this.LabelHistorial.Size = new System.Drawing.Size(208, 29);
            this.LabelHistorial.TabIndex = 46;
            this.LabelHistorial.Text = "Historial ID";
            this.LabelHistorial.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.Titulo, 4);
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(3, 0);
            this.Titulo.Name = "Titulo";
            this.tableLayoutPanel3.SetRowSpan(this.Titulo, 2);
            this.Titulo.Size = new System.Drawing.Size(425, 58);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Consulta Historial";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonCliente
            // 
            this.BotonCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.BotonCliente, 4);
            this.BotonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCliente.Location = new System.Drawing.Point(3, 293);
            this.BotonCliente.Name = "BotonCliente";
            this.tableLayoutPanel3.SetRowSpan(this.BotonCliente, 2);
            this.BotonCliente.Size = new System.Drawing.Size(425, 58);
            this.BotonCliente.TabIndex = 24;
            this.BotonCliente.Text = "Ok";
            this.BotonCliente.UseVisualStyleBackColor = true;
            this.BotonCliente.Click += new System.EventHandler(this.BotonCliente_Click_1);
            // 
            // LabelAnotaciones
            // 
            this.LabelAnotaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelAnotaciones, 2);
            this.LabelAnotaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAnotaciones.Location = new System.Drawing.Point(3, 232);
            this.LabelAnotaciones.Name = "LabelAnotaciones";
            this.LabelAnotaciones.Size = new System.Drawing.Size(208, 29);
            this.LabelAnotaciones.TabIndex = 27;
            this.LabelAnotaciones.Text = "Anotaciones";
            this.LabelAnotaciones.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LabelMotivo
            // 
            this.LabelMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelMotivo, 2);
            this.LabelMotivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMotivo.Location = new System.Drawing.Point(3, 174);
            this.LabelMotivo.Name = "LabelMotivo";
            this.LabelMotivo.Size = new System.Drawing.Size(208, 29);
            this.LabelMotivo.TabIndex = 22;
            this.LabelMotivo.Text = "Motivo";
            this.LabelMotivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextAnotaciones
            // 
            this.TextAnotaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextAnotaciones, 4);
            this.TextAnotaciones.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAnotaciones.Location = new System.Drawing.Point(3, 264);
            this.TextAnotaciones.Multiline = true;
            this.TextAnotaciones.Name = "TextAnotaciones";
            this.TextAnotaciones.Size = new System.Drawing.Size(425, 23);
            this.TextAnotaciones.TabIndex = 30;
            // 
            // TextMotivo
            // 
            this.TextMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextMotivo, 4);
            this.TextMotivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMotivo.Location = new System.Drawing.Point(3, 206);
            this.TextMotivo.Multiline = true;
            this.TextMotivo.Name = "TextMotivo";
            this.TextMotivo.Size = new System.Drawing.Size(425, 23);
            this.TextMotivo.TabIndex = 25;
            // 
            // BoxServID
            // 
            this.BoxServID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.BoxServID, 2);
            this.BoxServID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxServID.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxServID.FormattingEnabled = true;
            this.BoxServID.Location = new System.Drawing.Point(217, 148);
            this.BoxServID.Name = "BoxServID";
            this.BoxServID.Size = new System.Drawing.Size(211, 21);
            this.BoxServID.TabIndex = 45;
            // 
            // LabelServicio
            // 
            this.LabelServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelServicio, 2);
            this.LabelServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelServicio.Location = new System.Drawing.Point(217, 116);
            this.LabelServicio.Name = "LabelServicio";
            this.LabelServicio.Size = new System.Drawing.Size(211, 29);
            this.LabelServicio.TabIndex = 44;
            this.LabelServicio.Text = "Servicio";
            this.LabelServicio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BoxPacID
            // 
            this.BoxPacID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.BoxPacID, 2);
            this.BoxPacID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxPacID.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPacID.FormattingEnabled = true;
            this.BoxPacID.Location = new System.Drawing.Point(3, 148);
            this.BoxPacID.Name = "BoxPacID";
            this.BoxPacID.Size = new System.Drawing.Size(208, 21);
            this.BoxPacID.TabIndex = 41;
            // 
            // LabelPaciente
            // 
            this.LabelPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelPaciente, 2);
            this.LabelPaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPaciente.Location = new System.Drawing.Point(3, 116);
            this.LabelPaciente.Name = "LabelPaciente";
            this.LabelPaciente.Size = new System.Drawing.Size(208, 29);
            this.LabelPaciente.TabIndex = 21;
            this.LabelPaciente.Text = "Paciente";
            this.LabelPaciente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LabelVeterinario
            // 
            this.LabelVeterinario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelVeterinario, 2);
            this.LabelVeterinario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVeterinario.Location = new System.Drawing.Point(217, 58);
            this.LabelVeterinario.Name = "LabelVeterinario";
            this.LabelVeterinario.Size = new System.Drawing.Size(211, 29);
            this.LabelVeterinario.TabIndex = 2;
            this.LabelVeterinario.Text = "Veterinario";
            this.LabelVeterinario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BoxVetID
            // 
            this.BoxVetID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.BoxVetID, 2);
            this.BoxVetID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxVetID.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxVetID.FormattingEnabled = true;
            this.BoxVetID.Location = new System.Drawing.Point(217, 90);
            this.BoxVetID.Name = "BoxVetID";
            this.BoxVetID.Size = new System.Drawing.Size(211, 21);
            this.BoxVetID.TabIndex = 24;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.OpcionG, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.OpcionE, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.OpcionC, 4, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(431, 84);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // OpcionG
            // 
            this.OpcionG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcionG.Appearance = System.Windows.Forms.Appearance.Button;
            this.OpcionG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpcionG.BackgroundImage")));
            this.OpcionG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpcionG.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpcionG.ForeColor = System.Drawing.Color.Transparent;
            this.OpcionG.Location = new System.Drawing.Point(261, 3);
            this.OpcionG.Name = "OpcionG";
            this.OpcionG.Size = new System.Drawing.Size(80, 36);
            this.OpcionG.TabIndex = 1;
            this.OpcionG.UseVisualStyleBackColor = true;
            this.OpcionG.CheckedChanged += new System.EventHandler(this.OpcionG_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel4.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(166, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OpcionE
            // 
            this.OpcionE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcionE.Appearance = System.Windows.Forms.Appearance.Button;
            this.OpcionE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpcionE.BackgroundImage")));
            this.OpcionE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpcionE.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpcionE.ForeColor = System.Drawing.Color.Transparent;
            this.OpcionE.Location = new System.Drawing.Point(347, 3);
            this.OpcionE.Name = "OpcionE";
            this.OpcionE.Size = new System.Drawing.Size(81, 36);
            this.OpcionE.TabIndex = 2;
            this.OpcionE.UseVisualStyleBackColor = true;
            this.OpcionE.CheckedChanged += new System.EventHandler(this.OpcionE_CheckedChanged);
            // 
            // OpcionC
            // 
            this.OpcionC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcionC.Appearance = System.Windows.Forms.Appearance.Button;
            this.OpcionC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpcionC.BackgroundImage")));
            this.OpcionC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpcionC.Checked = true;
            this.OpcionC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpcionC.ForeColor = System.Drawing.Color.Transparent;
            this.OpcionC.Location = new System.Drawing.Point(347, 45);
            this.OpcionC.Name = "OpcionC";
            this.OpcionC.Size = new System.Drawing.Size(81, 36);
            this.OpcionC.TabIndex = 4;
            this.OpcionC.TabStop = true;
            this.OpcionC.UseVisualStyleBackColor = true;
            this.OpcionC.CheckedChanged += new System.EventHandler(this.OpcionC_CheckedChanged);
            // 
            // TablaHistorial
            // 
            this.TablaHistorial.AllowUserToAddRows = false;
            this.TablaHistorial.AllowUserToDeleteRows = false;
            this.TablaHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaHistorial.Location = new System.Drawing.Point(3, 3);
            this.TablaHistorial.Name = "TablaHistorial";
            this.TablaHistorial.ReadOnly = true;
            this.TablaHistorial.Size = new System.Drawing.Size(437, 450);
            this.TablaHistorial.TabIndex = 0;
            this.TablaHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaHistorial_CellClick);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Historial";
            this.Text = "Historial";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextTPID)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaHistorial)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label LabelHistorial;

        private System.Windows.Forms.NumericUpDown TextTPID;

        private System.Windows.Forms.Label LabelServicio;
        private System.Windows.Forms.ComboBox BoxServID;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox BoxPacID;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label LabelPaciente;
        private System.Windows.Forms.Label LabelVeterinario;
        private System.Windows.Forms.ComboBox BoxVetID;
        private System.Windows.Forms.Label LabelMotivo;
        private System.Windows.Forms.TextBox TextMotivo;
        private System.Windows.Forms.Label LabelAnotaciones;
        private System.Windows.Forms.TextBox TextAnotaciones;
        private System.Windows.Forms.Button BotonCliente;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton OpcionG;
        private System.Windows.Forms.RadioButton OpcionE;
        private System.Windows.Forms.RadioButton OpcionC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView TablaHistorial;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}