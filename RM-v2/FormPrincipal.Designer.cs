namespace RM_v2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            panelSeleccion = new Panel();
            panelDecorativo = new Panel();
            panelSalida = new Panel();
            btnCategorias = new Button();
            btnSalida = new Button();
            panelGrid = new Panel();
            panelSalida.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 94);
            panel1.TabIndex = 1;
            panel1.Click += panel1_Click;
            // 
            // panelSeleccion
            // 
            panelSeleccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSeleccion.AutoScroll = true;
            panelSeleccion.BackColor = Color.DarkSlateGray;
            panelSeleccion.Location = new Point(0, 94);
            panelSeleccion.Margin = new Padding(3, 4, 3, 4);
            panelSeleccion.Name = "panelSeleccion";
            panelSeleccion.Size = new Size(173, 516);
            panelSeleccion.TabIndex = 2;
            // 
            // panelDecorativo
            // 
            panelDecorativo.BackColor = Color.Azure;
            panelDecorativo.ForeColor = Color.Black;
            panelDecorativo.Location = new Point(0, 94);
            panelDecorativo.Margin = new Padding(3, 4, 3, 4);
            panelDecorativo.Name = "panelDecorativo";
            panelDecorativo.Size = new Size(7, 0);
            panelDecorativo.TabIndex = 10;
            // 
            // panelSalida
            // 
            panelSalida.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelSalida.BackColor = Color.DarkSlateGray;
            panelSalida.Controls.Add(btnCategorias);
            panelSalida.Controls.Add(btnSalida);
            panelSalida.Location = new Point(0, 608);
            panelSalida.Margin = new Padding(3, 4, 3, 4);
            panelSalida.Name = "panelSalida";
            panelSalida.Size = new Size(173, 65);
            panelSalida.TabIndex = 3;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.DarkSlateGray;
            btnCategorias.Dock = DockStyle.Right;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategorias.ForeColor = Color.FromArgb(192, 255, 255);
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.Location = new Point(87, 0);
            btnCategorias.Margin = new Padding(3, 4, 3, 4);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(86, 65);
            btnCategorias.TabIndex = 1;
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnSalida
            // 
            btnSalida.BackColor = Color.DarkSlateGray;
            btnSalida.BackgroundImageLayout = ImageLayout.None;
            btnSalida.Dock = DockStyle.Left;
            btnSalida.FlatAppearance.BorderSize = 0;
            btnSalida.FlatStyle = FlatStyle.Flat;
            btnSalida.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalida.ForeColor = Color.FromArgb(192, 255, 255);
            btnSalida.Location = new Point(0, 0);
            btnSalida.Margin = new Padding(3, 4, 3, 4);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(87, 65);
            btnSalida.TabIndex = 0;
            btnSalida.Text = "Salir";
            btnSalida.UseVisualStyleBackColor = false;
            btnSalida.Click += btnSalida_Click;
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.BackColor = Color.LightSteelBlue;
            panelGrid.Location = new Point(172, 0);
            panelGrid.Margin = new Padding(3, 4, 3, 4);
            panelGrid.Name = "panelGrid";
            panelGrid.RightToLeft = RightToLeft.No;
            panelGrid.Size = new Size(1089, 673);
            panelGrid.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelDecorativo);
            Controls.Add(panelGrid);
            Controls.Add(panelSalida);
            Controls.Add(panelSeleccion);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(960, 570);
            Name = "FormPrincipal";
            Text = "Stock";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            panelSalida.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelSeleccion;
        private Panel panelSalida;
        private Button btnSalida;
        private Panel panelGrid;
        private Panel panelDecorativo;
        private Button btnCategorias;
    }
}

