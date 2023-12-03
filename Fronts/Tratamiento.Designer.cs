using System.ComponentModel;

namespace Fronts {
    partial class Tratamiento {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tratamiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.OpcionG = new System.Windows.Forms.RadioButton();
            this.OpcionB = new System.Windows.Forms.RadioButton();
            this.OpcionE = new System.Windows.Forms.RadioButton();
            this.OpcionC = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BoxTipoID = new System.Windows.Forms.ComboBox();
            this.LabelTipo = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.BotonCliente = new System.Windows.Forms.Button();
            this.LabelTraID = new System.Windows.Forms.Label();
            this.TextTraID = new System.Windows.Forms.NumericUpDown();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TablaTT = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextTraID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaTT)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TablaTT, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 390);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 384);
            this.tableLayoutPanel2.TabIndex = 1;
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
            this.tableLayoutPanel4.Controls.Add(this.OpcionB, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.OpcionE, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.OpcionC, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(388, 70);
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
            this.OpcionG.Location = new System.Drawing.Point(234, 3);
            this.OpcionG.Name = "OpcionG";
            this.OpcionG.Size = new System.Drawing.Size(71, 29);
            this.OpcionG.TabIndex = 1;
            this.OpcionG.UseVisualStyleBackColor = true;
            this.OpcionG.CheckedChanged += new System.EventHandler(this.OpcionG_CheckedChanged);
            // 
            // OpcionB
            // 
            this.OpcionB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.OpcionB.Appearance = System.Windows.Forms.Appearance.Button;
            this.OpcionB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpcionB.BackgroundImage")));
            this.OpcionB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpcionB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpcionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpcionB.ForeColor = System.Drawing.Color.Transparent;
            this.OpcionB.Location = new System.Drawing.Point(311, 3);
            this.OpcionB.Name = "OpcionB";
            this.OpcionB.Size = new System.Drawing.Size(74, 29);
            this.OpcionB.TabIndex = 3;
            this.OpcionB.UseVisualStyleBackColor = true;
            this.OpcionB.CheckedChanged += new System.EventHandler(this.OpcionB_CheckedChanged);
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
            this.OpcionE.Location = new System.Drawing.Point(311, 38);
            this.OpcionE.Name = "OpcionE";
            this.OpcionE.Size = new System.Drawing.Size(74, 29);
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
            this.OpcionC.Location = new System.Drawing.Point(234, 38);
            this.OpcionC.Name = "OpcionC";
            this.OpcionC.Size = new System.Drawing.Size(71, 29);
            this.OpcionC.TabIndex = 4;
            this.OpcionC.TabStop = true;
            this.OpcionC.UseVisualStyleBackColor = true;
            this.OpcionC.CheckedChanged += new System.EventHandler(this.OpcionC_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel4.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(148, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.BoxTipoID, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.LabelTipo, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.Titulo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BotonCliente, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.LabelTraID, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TextTraID, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.LabelNombre, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.TextNombre, 0, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 79);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 302);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // BoxTipoID
            // 
            this.BoxTipoID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.BoxTipoID, 2);
            this.BoxTipoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxTipoID.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTipoID.FormattingEnabled = true;
            this.BoxTipoID.Location = new System.Drawing.Point(197, 114);
            this.BoxTipoID.Name = "BoxTipoID";
            this.BoxTipoID.Size = new System.Drawing.Size(188, 21);
            this.BoxTipoID.TabIndex = 42;
            // 
            // LabelTipo
            // 
            this.LabelTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelTipo, 2);
            this.LabelTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTipo.Location = new System.Drawing.Point(197, 74);
            this.LabelTipo.Name = "LabelTipo";
            this.LabelTipo.Size = new System.Drawing.Size(188, 37);
            this.LabelTipo.TabIndex = 41;
            this.LabelTipo.Text = "Tipo";
            this.LabelTipo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.Titulo, 4);
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(3, 0);
            this.Titulo.Name = "Titulo";
            this.tableLayoutPanel3.SetRowSpan(this.Titulo, 2);
            this.Titulo.Size = new System.Drawing.Size(382, 74);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Consulta Tratamiento";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonCliente
            // 
            this.BotonCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.BotonCliente, 4);
            this.BotonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCliente.Location = new System.Drawing.Point(3, 225);
            this.BotonCliente.Name = "BotonCliente";
            this.tableLayoutPanel3.SetRowSpan(this.BotonCliente, 2);
            this.BotonCliente.Size = new System.Drawing.Size(382, 74);
            this.BotonCliente.TabIndex = 24;
            this.BotonCliente.Text = "Ok";
            this.BotonCliente.UseVisualStyleBackColor = true;
            this.BotonCliente.Click += new System.EventHandler(this.BotonCliente_Click);
            // 
            // LabelTraID
            // 
            this.LabelTraID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelTraID, 2);
            this.LabelTraID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTraID.Location = new System.Drawing.Point(3, 74);
            this.LabelTraID.Name = "LabelTraID";
            this.LabelTraID.Size = new System.Drawing.Size(188, 37);
            this.LabelTraID.TabIndex = 2;
            this.LabelTraID.Text = "Tratamiento ID";
            this.LabelTraID.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextTraID
            // 
            this.TextTraID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextTraID, 2);
            this.TextTraID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTraID.Location = new System.Drawing.Point(3, 114);
            this.TextTraID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.TextTraID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.TextTraID.Name = "TextTraID";
            this.TextTraID.Size = new System.Drawing.Size(188, 21);
            this.TextTraID.TabIndex = 40;
            this.TextTraID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LabelNombre
            // 
            this.LabelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelNombre, 2);
            this.LabelNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.Location = new System.Drawing.Point(3, 148);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(188, 37);
            this.LabelNombre.TabIndex = 22;
            this.LabelNombre.Text = "Nombre";
            this.LabelNombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextNombre
            // 
            this.TextNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextNombre, 4);
            this.TextNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombre.Location = new System.Drawing.Point(3, 188);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(382, 21);
            this.TextNombre.TabIndex = 25;
            // 
            // TablaTT
            // 
            this.TablaTT.AllowUserToAddRows = false;
            this.TablaTT.AllowUserToDeleteRows = false;
            this.TablaTT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaTT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaTT.Location = new System.Drawing.Point(3, 3);
            this.TablaTT.Name = "TablaTT";
            this.TablaTT.ReadOnly = true;
            this.TablaTT.Size = new System.Drawing.Size(394, 384);
            this.TablaTT.TabIndex = 0;
            this.TablaTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaTT_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 30);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 7;
            // 
            // Tratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Tratamiento";
            this.Text = "Tratamiento";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextTraID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaTT)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox BoxTipoID;

        private System.Windows.Forms.Label LabelTipo;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton OpcionG;
        private System.Windows.Forms.RadioButton OpcionB;
        private System.Windows.Forms.RadioButton OpcionE;
        private System.Windows.Forms.RadioButton OpcionC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button BotonCliente;
        private System.Windows.Forms.Label LabelTraID;
        private System.Windows.Forms.NumericUpDown TextTraID;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.DataGridView TablaTT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}