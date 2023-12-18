namespace RM_v2.Forms
{
    partial class FormRuedas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label5 = new Label();
            label4 = new Label();
            numericSuletos = new NumericUpDown();
            numericBolsas = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDescripcion = new TextBox();
            textBoxNombre = new TextBox();
            textBoxCodigo = new TextBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            panelGrid = new Panel();
            textBoxBuscar = new TextBox();
            dataGridViewRuedas = new DataGridView();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadSueltaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadBolsasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accesorioBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)numericSuletos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBolsas).BeginInit();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRuedas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accesorioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1029, 36);
            label5.Name = "label5";
            label5.Size = new Size(121, 19);
            label5.TabIndex = 42;
            label5.Text = "Cantidad suelta";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1029, 151);
            label4.Name = "label4";
            label4.Size = new Size(124, 19);
            label4.TabIndex = 41;
            label4.Text = "Cantidad bolsas";
            // 
            // numericSuletos
            // 
            numericSuletos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericSuletos.BorderStyle = BorderStyle.FixedSingle;
            numericSuletos.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            numericSuletos.Location = new Point(1033, 64);
            numericSuletos.Margin = new Padding(3, 4, 3, 4);
            numericSuletos.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericSuletos.Name = "numericSuletos";
            numericSuletos.Size = new Size(306, 35);
            numericSuletos.TabIndex = 40;
            // 
            // numericBolsas
            // 
            numericBolsas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericBolsas.BorderStyle = BorderStyle.FixedSingle;
            numericBolsas.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            numericBolsas.Location = new Point(1033, 179);
            numericBolsas.Margin = new Padding(3, 4, 3, 4);
            numericBolsas.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericBolsas.Name = "numericBolsas";
            numericBolsas.Size = new Size(306, 35);
            numericBolsas.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 152);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 38;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(427, 38);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 37;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 38);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 36;
            label1.Text = "Codigo";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescripcion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescripcion.Location = new Point(56, 180);
            textBoxDescripcion.Margin = new Padding(3, 4, 3, 4);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(718, 241);
            textBoxDescripcion.TabIndex = 35;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.Location = new Point(431, 65);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(343, 34);
            textBoxNombre.TabIndex = 34;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodigo.Location = new Point(56, 65);
            textBoxCodigo.Margin = new Padding(3, 4, 3, 4);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(343, 34);
            textBoxCodigo.TabIndex = 33;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(56, 429);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 51);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(1211, 429);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(128, 51);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(1077, 429);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(128, 51);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.Controls.Add(textBoxBuscar);
            panelGrid.Controls.Add(dataGridViewRuedas);
            panelGrid.Location = new Point(0, 488);
            panelGrid.Margin = new Padding(3, 4, 3, 4);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1392, 579);
            panelGrid.TabIndex = 16;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBuscar.ForeColor = Color.Silver;
            textBoxBuscar.Location = new Point(56, 21);
            textBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(441, 34);
            textBoxBuscar.TabIndex = 23;
            textBoxBuscar.Text = "Buscar...";
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            textBoxBuscar.Enter += textBoxBuscar_Enter;
            textBoxBuscar.Leave += textBoxBuscar_Leave;
            // 
            // dataGridViewRuedas
            // 
            dataGridViewRuedas.AllowUserToAddRows = false;
            dataGridViewRuedas.AllowUserToDeleteRows = false;
            dataGridViewRuedas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRuedas.AutoGenerateColumns = false;
            dataGridViewRuedas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRuedas.BackgroundColor = Color.White;
            dataGridViewRuedas.BorderStyle = BorderStyle.None;
            dataGridViewRuedas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewRuedas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRuedas.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, cantidadSueltaDataGridViewTextBoxColumn, cantidadBolsasDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            dataGridViewRuedas.DataSource = accesorioBindingSource;
            dataGridViewRuedas.Location = new Point(56, 71);
            dataGridViewRuedas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRuedas.Name = "dataGridViewRuedas";
            dataGridViewRuedas.ReadOnly = true;
            dataGridViewRuedas.RowHeadersWidth = 51;
            dataGridViewRuedas.RowTemplate.Height = 24;
            dataGridViewRuedas.Size = new Size(1283, 448);
            dataGridViewRuedas.TabIndex = 22;
            dataGridViewRuedas.RowHeaderMouseDoubleClick += dataGridViewRuedas_RowHeaderMouseDoubleClick;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadSueltaDataGridViewTextBoxColumn
            // 
            cantidadSueltaDataGridViewTextBoxColumn.DataPropertyName = "CantidadSuelta";
            cantidadSueltaDataGridViewTextBoxColumn.HeaderText = "CantidadSuelta";
            cantidadSueltaDataGridViewTextBoxColumn.MinimumWidth = 6;
            cantidadSueltaDataGridViewTextBoxColumn.Name = "cantidadSueltaDataGridViewTextBoxColumn";
            cantidadSueltaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadBolsasDataGridViewTextBoxColumn
            // 
            cantidadBolsasDataGridViewTextBoxColumn.DataPropertyName = "CantidadBolsas";
            cantidadBolsasDataGridViewTextBoxColumn.HeaderText = "CantidadBolsas";
            cantidadBolsasDataGridViewTextBoxColumn.MinimumWidth = 6;
            cantidadBolsasDataGridViewTextBoxColumn.Name = "cantidadBolsasDataGridViewTextBoxColumn";
            cantidadBolsasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accesorioBindingSource
            // 
            accesorioBindingSource.DataSource = typeof(Objects.Accesorio);
            // 
            // FormRuedas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1392, 1066);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericSuletos);
            Controls.Add(numericBolsas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxCodigo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(panelGrid);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRuedas";
            Text = "FormRuedas";
            ((System.ComponentModel.ISupportInitialize)numericSuletos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBolsas).EndInit();
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRuedas).EndInit();
            ((System.ComponentModel.ISupportInitialize)accesorioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource accesorioBindingSource;
        private Label label5;
        private Label label4;
        private NumericUpDown numericSuletos;
        private NumericUpDown numericBolsas;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDescripcion;
        private TextBox textBoxNombre;
        private TextBox textBoxCodigo;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Panel panelGrid;
        private TextBox textBoxBuscar;
        private DataGridView dataGridViewRuedas;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadSueltaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadBolsasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}