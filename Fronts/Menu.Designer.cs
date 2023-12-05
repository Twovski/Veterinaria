namespace Fronts {
    partial class Menu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionVeterinario = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionTratamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BotonCliente = new System.Windows.Forms.Button();
            this.BotonPaciente = new System.Windows.Forms.Button();
            this.BotonExpediente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.opcionesToolStripMenuItem, this.OpcionInfo });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.OpcionVeterinario, this.OpcionTratamiento, this.OpcionServicio });
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // OpcionVeterinario
            // 
            this.OpcionVeterinario.Name = "OpcionVeterinario";
            this.OpcionVeterinario.Size = new System.Drawing.Size(177, 26);
            this.OpcionVeterinario.Text = "Veterinario";
            this.OpcionVeterinario.Click += new System.EventHandler(this.OpcionVeterinario_Click);
            // 
            // OpcionTratamiento
            // 
            this.OpcionTratamiento.Name = "OpcionTratamiento";
            this.OpcionTratamiento.Size = new System.Drawing.Size(177, 26);
            this.OpcionTratamiento.Text = "Tratamiento";
            this.OpcionTratamiento.Click += new System.EventHandler(this.OpcionTratamiento_Click);
            // 
            // OpcionServicio
            // 
            this.OpcionServicio.Name = "OpcionServicio";
            this.OpcionServicio.Size = new System.Drawing.Size(177, 26);
            this.OpcionServicio.Text = "Servicios";
            this.OpcionServicio.Click += new System.EventHandler(this.OpcionServicio_Click);
            // 
            // OpcionInfo
            // 
            this.OpcionInfo.Name = "OpcionInfo";
            this.OpcionInfo.Size = new System.Drawing.Size(116, 25);
            this.OpcionInfo.Text = "Infromacion";
            this.OpcionInfo.Click += new System.EventHandler(this.OpcionInfo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.BotonCliente, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BotonPaciente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BotonExpediente, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 391);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // BotonCliente
            // 
            this.BotonCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCliente.BackColor = System.Drawing.Color.Transparent;
            this.BotonCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonCliente.BackgroundImage")));
            this.BotonCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonCliente.FlatAppearance.BorderSize = 0;
            this.BotonCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.BotonCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.BotonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCliente.ForeColor = System.Drawing.Color.Transparent;
            this.BotonCliente.Location = new System.Drawing.Point(3, 133);
            this.BotonCliente.Name = "BotonCliente";
            this.BotonCliente.Size = new System.Drawing.Size(260, 124);
            this.BotonCliente.TabIndex = 0;
            this.BotonCliente.UseVisualStyleBackColor = false;
            this.BotonCliente.Click += new System.EventHandler(this.BotonCliente_Click);
            // 
            // BotonPaciente
            // 
            this.BotonPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonPaciente.BackColor = System.Drawing.Color.Transparent;
            this.BotonPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonPaciente.BackgroundImage")));
            this.BotonPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonPaciente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BotonPaciente.FlatAppearance.BorderSize = 0;
            this.BotonPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.BotonPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.BotonPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPaciente.ForeColor = System.Drawing.Color.Transparent;
            this.BotonPaciente.Location = new System.Drawing.Point(269, 133);
            this.BotonPaciente.Name = "BotonPaciente";
            this.BotonPaciente.Size = new System.Drawing.Size(260, 124);
            this.BotonPaciente.TabIndex = 1;
            this.BotonPaciente.UseVisualStyleBackColor = false;
            this.BotonPaciente.Click += new System.EventHandler(this.BotonPaciente_Click);
            // 
            // BotonExpediente
            // 
            this.BotonExpediente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonExpediente.BackColor = System.Drawing.Color.Transparent;
            this.BotonExpediente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotonExpediente.BackgroundImage")));
            this.BotonExpediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonExpediente.FlatAppearance.BorderSize = 0;
            this.BotonExpediente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.BotonExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.BotonExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonExpediente.ForeColor = System.Drawing.Color.Transparent;
            this.BotonExpediente.Location = new System.Drawing.Point(535, 133);
            this.BotonExpediente.Name = "BotonExpediente";
            this.BotonExpediente.Size = new System.Drawing.Size(262, 124);
            this.BotonExpediente.TabIndex = 2;
            this.BotonExpediente.UseVisualStyleBackColor = false;
            this.BotonExpediente.Click += new System.EventHandler(this.BotonExpediente_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pacientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expedientes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.UseMnemonic = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "A";
            this.notifyIcon1.BalloonTipTitle = "S";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NotifyIcon notifyIcon1;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button BotonCliente;
        private System.Windows.Forms.Button BotonPaciente;
        private System.Windows.Forms.Button BotonExpediente;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.ToolStripMenuItem OpcionVeterinario;
        private System.Windows.Forms.ToolStripMenuItem OpcionTratamiento;
        private System.Windows.Forms.ToolStripMenuItem OpcionServicio;
        private System.Windows.Forms.ToolStripMenuItem OpcionInfo;

        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}