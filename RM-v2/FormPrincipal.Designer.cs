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
            panel1 = new Panel();
            panelSeleccion = new Panel();
            panelDecorativo = new Panel();
            btnOtros = new Button();
            btnCerraduras = new Button();
            btnPlasticos = new Button();
            btnRuedas = new Button();
            btnPicaportes = new Button();
            btnEscuadras = new Button();
            btnBisagras = new Button();
            panelSalida = new Panel();
            btnSalida = new Button();
            panelGrid = new Panel();
            panelSeleccion.SuspendLayout();
            panelSalida.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 200);
            panel1.TabIndex = 1;
            panel1.Click += panel1_Click;
            // 
            // panelSeleccion
            // 
            panelSeleccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSeleccion.AutoScroll = true;
            panelSeleccion.BackColor = Color.DarkSlateGray;
            panelSeleccion.Controls.Add(panelDecorativo);
            panelSeleccion.Controls.Add(btnOtros);
            panelSeleccion.Controls.Add(btnCerraduras);
            panelSeleccion.Controls.Add(btnPlasticos);
            panelSeleccion.Controls.Add(btnRuedas);
            panelSeleccion.Controls.Add(btnPicaportes);
            panelSeleccion.Controls.Add(btnEscuadras);
            panelSeleccion.Controls.Add(btnBisagras);
            panelSeleccion.Location = new Point(0, 200);
            panelSeleccion.Margin = new Padding(3, 4, 3, 4);
            panelSeleccion.Name = "panelSeleccion";
            panelSeleccion.Size = new Size(190, 788);
            panelSeleccion.TabIndex = 2;
            // 
            // panelDecorativo
            // 
            panelDecorativo.BackColor = Color.Azure;
            panelDecorativo.ForeColor = Color.Black;
            panelDecorativo.Location = new Point(0, 0);
            panelDecorativo.Margin = new Padding(3, 4, 3, 4);
            panelDecorativo.Name = "panelDecorativo";
            panelDecorativo.Size = new Size(7, 438);
            panelDecorativo.TabIndex = 10;
            // 
            // btnOtros
            // 
            btnOtros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnOtros.FlatAppearance.BorderSize = 0;
            btnOtros.FlatStyle = FlatStyle.Flat;
            btnOtros.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOtros.ForeColor = Color.FromArgb(192, 255, 255);
            btnOtros.Location = new Point(0, 375);
            btnOtros.Margin = new Padding(3, 4, 3, 4);
            btnOtros.Name = "btnOtros";
            btnOtros.Size = new Size(190, 62);
            btnOtros.TabIndex = 9;
            btnOtros.Text = "Otros";
            btnOtros.UseVisualStyleBackColor = true;
            btnOtros.Click += btnOtros_Click;
            // 
            // btnCerraduras
            // 
            btnCerraduras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCerraduras.FlatAppearance.BorderSize = 0;
            btnCerraduras.FlatStyle = FlatStyle.Flat;
            btnCerraduras.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerraduras.ForeColor = Color.FromArgb(192, 255, 255);
            btnCerraduras.Location = new Point(0, 312);
            btnCerraduras.Margin = new Padding(3, 4, 3, 4);
            btnCerraduras.Name = "btnCerraduras";
            btnCerraduras.Size = new Size(190, 62);
            btnCerraduras.TabIndex = 8;
            btnCerraduras.Text = "Cerraduras/Cierres";
            btnCerraduras.UseVisualStyleBackColor = true;
            btnCerraduras.Click += btnCerraduras_Click;
            // 
            // btnPlasticos
            // 
            btnPlasticos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPlasticos.FlatAppearance.BorderSize = 0;
            btnPlasticos.FlatStyle = FlatStyle.Flat;
            btnPlasticos.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlasticos.ForeColor = Color.FromArgb(192, 255, 255);
            btnPlasticos.Location = new Point(0, 250);
            btnPlasticos.Margin = new Padding(3, 4, 3, 4);
            btnPlasticos.Name = "btnPlasticos";
            btnPlasticos.Size = new Size(190, 62);
            btnPlasticos.TabIndex = 7;
            btnPlasticos.Text = "Plasticos";
            btnPlasticos.UseVisualStyleBackColor = true;
            btnPlasticos.Click += btnPlasticos_Click;
            // 
            // btnRuedas
            // 
            btnRuedas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRuedas.FlatAppearance.BorderSize = 0;
            btnRuedas.FlatStyle = FlatStyle.Flat;
            btnRuedas.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRuedas.ForeColor = Color.FromArgb(192, 255, 255);
            btnRuedas.Location = new Point(0, 188);
            btnRuedas.Margin = new Padding(3, 4, 3, 4);
            btnRuedas.Name = "btnRuedas";
            btnRuedas.Size = new Size(190, 62);
            btnRuedas.TabIndex = 6;
            btnRuedas.Text = "Ruedas";
            btnRuedas.UseVisualStyleBackColor = true;
            btnRuedas.Click += btnRuedas_Click;
            // 
            // btnPicaportes
            // 
            btnPicaportes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPicaportes.FlatAppearance.BorderSize = 0;
            btnPicaportes.FlatStyle = FlatStyle.Flat;
            btnPicaportes.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPicaportes.ForeColor = Color.FromArgb(192, 255, 255);
            btnPicaportes.Location = new Point(0, 125);
            btnPicaportes.Margin = new Padding(3, 4, 3, 4);
            btnPicaportes.Name = "btnPicaportes";
            btnPicaportes.Size = new Size(190, 62);
            btnPicaportes.TabIndex = 5;
            btnPicaportes.Text = "Picaportes";
            btnPicaportes.UseVisualStyleBackColor = true;
            btnPicaportes.Click += btnPicaportes_Click;
            // 
            // btnEscuadras
            // 
            btnEscuadras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEscuadras.FlatAppearance.BorderSize = 0;
            btnEscuadras.FlatStyle = FlatStyle.Flat;
            btnEscuadras.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEscuadras.ForeColor = Color.FromArgb(192, 255, 255);
            btnEscuadras.Location = new Point(0, 62);
            btnEscuadras.Margin = new Padding(3, 4, 3, 4);
            btnEscuadras.Name = "btnEscuadras";
            btnEscuadras.Size = new Size(190, 62);
            btnEscuadras.TabIndex = 4;
            btnEscuadras.Text = "Escuadras";
            btnEscuadras.UseVisualStyleBackColor = true;
            btnEscuadras.Click += btnEscuadras_Click;
            // 
            // btnBisagras
            // 
            btnBisagras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBisagras.FlatAppearance.BorderSize = 0;
            btnBisagras.FlatStyle = FlatStyle.Flat;
            btnBisagras.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBisagras.ForeColor = Color.FromArgb(192, 255, 255);
            btnBisagras.Location = new Point(0, 0);
            btnBisagras.Margin = new Padding(3, 4, 3, 4);
            btnBisagras.Name = "btnBisagras";
            btnBisagras.Size = new Size(190, 62);
            btnBisagras.TabIndex = 3;
            btnBisagras.Text = "Bisagras";
            btnBisagras.UseVisualStyleBackColor = true;
            btnBisagras.Click += btnBisagras_Click;
            // 
            // panelSalida
            // 
            panelSalida.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelSalida.BackColor = Color.DarkSlateGray;
            panelSalida.Controls.Add(btnSalida);
            panelSalida.Location = new Point(0, 988);
            panelSalida.Margin = new Padding(3, 4, 3, 4);
            panelSalida.Name = "panelSalida";
            panelSalida.Size = new Size(190, 79);
            panelSalida.TabIndex = 3;
            // 
            // btnSalida
            // 
            btnSalida.BackColor = Color.DarkSlateGray;
            btnSalida.BackgroundImageLayout = ImageLayout.None;
            btnSalida.Dock = DockStyle.Fill;
            btnSalida.FlatAppearance.BorderSize = 0;
            btnSalida.FlatStyle = FlatStyle.Flat;
            btnSalida.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalida.ForeColor = Color.FromArgb(192, 255, 255);
            btnSalida.Location = new Point(0, 0);
            btnSalida.Margin = new Padding(3, 4, 3, 4);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(190, 79);
            btnSalida.TabIndex = 0;
            btnSalida.Text = "Salir";
            btnSalida.UseVisualStyleBackColor = false;
            btnSalida.Click += btnSalida_Click;
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.BackColor = Color.LightSteelBlue;
            panelGrid.Location = new Point(190, 0);
            panelGrid.Margin = new Padding(3, 4, 3, 4);
            panelGrid.Name = "panelGrid";
            panelGrid.RightToLeft = RightToLeft.No;
            panelGrid.Size = new Size(1392, 1066);
            panelGrid.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1582, 1055);
            Controls.Add(panelGrid);
            Controls.Add(panelSalida);
            Controls.Add(panelSeleccion);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1360, 771);
            Name = "FormPrincipal";
            Text = "Stock";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            panelSeleccion.ResumeLayout(false);
            panelSalida.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelSeleccion;
        private Button btnOtros;
        private Button btnCerraduras;
        private Button btnPlasticos;
        private Button btnRuedas;
        private Button btnPicaportes;
        private Button btnEscuadras;
        private Button btnBisagras;
        private Panel panelSalida;
        private Button btnSalida;
        private Panel panelGrid;
        private Panel panelDecorativo;
    }
}

