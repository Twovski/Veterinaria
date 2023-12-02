using System.ComponentModel;

namespace Fronts {
    partial class Veterinario {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veterinario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.OpcionG = new System.Windows.Forms.RadioButton();
            this.OpcionB = new System.Windows.Forms.RadioButton();
            this.OpcionE = new System.Windows.Forms.RadioButton();
            this.OpcionC = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TextAM = new System.Windows.Forms.TextBox();
            this.LabelAM = new System.Windows.Forms.Label();
            this.TextAP = new System.Windows.Forms.TextBox();
            this.LabelAP = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.LabelVetID = new System.Windows.Forms.Label();
            this.TextVetID = new System.Windows.Forms.NumericUpDown();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.BotonCliente = new System.Windows.Forms.Button();
            this.TextRFC = new System.Windows.Forms.TextBox();
            this.LabelRFC = new System.Windows.Forms.Label();
            this.TextCorreo = new System.Windows.Forms.TextBox();
            this.LabelCorreo = new System.Windows.Forms.Label();
            this.TablaVeterinario = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextVetID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVeterinario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 30);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TablaVeterinario, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 390);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.tableLayoutPanel3.Controls.Add(this.TextAM, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.LabelAM, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.TextAP, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.LabelAP, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.Titulo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LabelVetID, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TextVetID, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.TextNombre, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.LabelNombre, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.BotonCliente, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.TextRFC, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.LabelRFC, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.TextCorreo, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.LabelCorreo, 0, 6);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 79);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 12;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 302);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // TextAM
            // 
            this.TextAM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextAM, 2);
            this.TextAM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAM.Location = new System.Drawing.Point(197, 128);
            this.TextAM.Name = "TextAM";
            this.TextAM.Size = new System.Drawing.Size(188, 21);
            this.TextAM.TabIndex = 46;
            // 
            // LabelAM
            // 
            this.LabelAM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelAM, 2);
            this.LabelAM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAM.Location = new System.Drawing.Point(197, 100);
            this.LabelAM.Name = "LabelAM";
            this.LabelAM.Size = new System.Drawing.Size(188, 25);
            this.LabelAM.TabIndex = 45;
            this.LabelAM.Text = "Apellido Materno";
            this.LabelAM.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextAP
            // 
            this.TextAP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextAP, 2);
            this.TextAP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAP.Location = new System.Drawing.Point(3, 128);
            this.TextAP.Name = "TextAP";
            this.TextAP.Size = new System.Drawing.Size(188, 21);
            this.TextAP.TabIndex = 44;
            // 
            // LabelAP
            // 
            this.LabelAP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelAP, 2);
            this.LabelAP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAP.Location = new System.Drawing.Point(3, 100);
            this.LabelAP.Name = "LabelAP";
            this.LabelAP.Size = new System.Drawing.Size(188, 25);
            this.LabelAP.TabIndex = 43;
            this.LabelAP.Text = "Apellido Paterno";
            this.LabelAP.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.Titulo, 4);
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(3, 0);
            this.Titulo.Name = "Titulo";
            this.tableLayoutPanel3.SetRowSpan(this.Titulo, 2);
            this.Titulo.Size = new System.Drawing.Size(382, 50);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Consultar Veterinario";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelVetID
            // 
            this.LabelVetID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelVetID, 2);
            this.LabelVetID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVetID.Location = new System.Drawing.Point(3, 50);
            this.LabelVetID.Name = "LabelVetID";
            this.LabelVetID.Size = new System.Drawing.Size(188, 25);
            this.LabelVetID.TabIndex = 2;
            this.LabelVetID.Text = "Veterinario ID";
            this.LabelVetID.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextVetID
            // 
            this.TextVetID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextVetID, 2);
            this.TextVetID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextVetID.Location = new System.Drawing.Point(3, 78);
            this.TextVetID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.TextVetID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.TextVetID.Name = "TextVetID";
            this.TextVetID.Size = new System.Drawing.Size(188, 21);
            this.TextVetID.TabIndex = 40;
            this.TextVetID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TextNombre
            // 
            this.TextNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextNombre, 2);
            this.TextNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombre.Location = new System.Drawing.Point(197, 78);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(188, 21);
            this.TextNombre.TabIndex = 25;
            // 
            // LabelNombre
            // 
            this.LabelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelNombre, 2);
            this.LabelNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.Location = new System.Drawing.Point(197, 50);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(188, 25);
            this.LabelNombre.TabIndex = 22;
            this.LabelNombre.Text = "Nombre";
            this.LabelNombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BotonCliente
            // 
            this.BotonCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.BotonCliente, 4);
            this.BotonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCliente.Location = new System.Drawing.Point(3, 253);
            this.BotonCliente.Name = "BotonCliente";
            this.tableLayoutPanel3.SetRowSpan(this.BotonCliente, 2);
            this.BotonCliente.Size = new System.Drawing.Size(382, 46);
            this.BotonCliente.TabIndex = 24;
            this.BotonCliente.Text = "Ok";
            this.BotonCliente.UseVisualStyleBackColor = true;
            this.BotonCliente.Click += new System.EventHandler(this.BotonCliente_Click);
            // 
            // TextRFC
            // 
            this.TextRFC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextRFC, 4);
            this.TextRFC.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRFC.Location = new System.Drawing.Point(3, 228);
            this.TextRFC.Name = "TextRFC";
            this.TextRFC.Size = new System.Drawing.Size(382, 21);
            this.TextRFC.TabIndex = 42;
            // 
            // LabelRFC
            // 
            this.LabelRFC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelRFC, 2);
            this.LabelRFC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRFC.Location = new System.Drawing.Point(3, 200);
            this.LabelRFC.Name = "LabelRFC";
            this.LabelRFC.Size = new System.Drawing.Size(188, 25);
            this.LabelRFC.TabIndex = 41;
            this.LabelRFC.Text = "RFC";
            this.LabelRFC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextCorreo
            // 
            this.TextCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.TextCorreo, 4);
            this.TextCorreo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCorreo.Location = new System.Drawing.Point(3, 178);
            this.TextCorreo.Name = "TextCorreo";
            this.TextCorreo.Size = new System.Drawing.Size(382, 21);
            this.TextCorreo.TabIndex = 30;
            // 
            // LabelCorreo
            // 
            this.LabelCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.LabelCorreo, 2);
            this.LabelCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCorreo.Location = new System.Drawing.Point(3, 150);
            this.LabelCorreo.Name = "LabelCorreo";
            this.LabelCorreo.Size = new System.Drawing.Size(188, 25);
            this.LabelCorreo.TabIndex = 27;
            this.LabelCorreo.Text = "Correo";
            this.LabelCorreo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TablaVeterinario
            // 
            this.TablaVeterinario.AllowUserToAddRows = false;
            this.TablaVeterinario.AllowUserToDeleteRows = false;
            this.TablaVeterinario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaVeterinario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaVeterinario.Location = new System.Drawing.Point(3, 3);
            this.TablaVeterinario.Name = "TablaVeterinario";
            this.TablaVeterinario.ReadOnly = true;
            this.TablaVeterinario.Size = new System.Drawing.Size(394, 384);
            this.TablaVeterinario.TabIndex = 0;
            this.TablaVeterinario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaVeterinario_CellClick);
            // 
            // Veterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Veterinario";
            this.Text = "Veterinario";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextVetID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVeterinario)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label LabelAP;

        private System.Windows.Forms.Label LabelAM;

        private System.Windows.Forms.TextBox TextAP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextAM;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox TextRFC;

        private System.Windows.Forms.Label LabelRFC;

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
        private System.Windows.Forms.Label LabelVetID;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.Label LabelCorreo;
        private System.Windows.Forms.TextBox TextCorreo;
        private System.Windows.Forms.NumericUpDown TextVetID;
        private System.Windows.Forms.Button BotonCliente;
        private System.Windows.Forms.DataGridView TablaVeterinario;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}