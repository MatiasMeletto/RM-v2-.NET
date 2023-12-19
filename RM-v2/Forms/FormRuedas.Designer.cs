﻿namespace RM_v2.Forms
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
            panelGrid = new Panel();
            textBoxBuscar = new TextBox();
            dataGridViewRuedas = new DataGridView();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadSueltaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadBolsasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accesorioBindingSource = new BindingSource(components);
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
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRuedas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accesorioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSuletos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBolsas).BeginInit();
            SuspendLayout();
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.Controls.Add(textBoxBuscar);
            panelGrid.Controls.Add(dataGridViewRuedas);
            panelGrid.Location = new Point(0, 277);
            panelGrid.Margin = new Padding(3, 4, 3, 4);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1089, 397);
            panelGrid.TabIndex = 16;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBuscar.ForeColor = Color.Silver;
            textBoxBuscar.Location = new Point(52, 29);
            textBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(445, 34);
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
            dataGridViewRuedas.Location = new Point(52, 71);
            dataGridViewRuedas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRuedas.Name = "dataGridViewRuedas";
            dataGridViewRuedas.ReadOnly = true;
            dataGridViewRuedas.RowHeadersWidth = 51;
            dataGridViewRuedas.RowTemplate.Height = 24;
            dataGridViewRuedas.Size = new Size(984, 266);
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
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(898, 43);
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
            label4.Location = new Point(898, 110);
            label4.Name = "label4";
            label4.Size = new Size(124, 19);
            label4.TabIndex = 41;
            label4.Text = "Cantidad bolsas";
            // 
            // numericSuletos
            // 
            numericSuletos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericSuletos.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            numericSuletos.Location = new Point(898, 66);
            numericSuletos.Margin = new Padding(3, 4, 3, 4);
            numericSuletos.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericSuletos.Name = "numericSuletos";
            numericSuletos.Size = new Size(141, 35);
            numericSuletos.TabIndex = 40;
            // 
            // numericBolsas
            // 
            numericBolsas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericBolsas.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            numericBolsas.Location = new Point(898, 133);
            numericBolsas.Margin = new Padding(3, 4, 3, 4);
            numericBolsas.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericBolsas.Name = "numericBolsas";
            numericBolsas.Size = new Size(138, 35);
            numericBolsas.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 109);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 38;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(308, 39);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 37;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 39);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 36;
            label1.Text = "Codigo";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescripcion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescripcion.Location = new Point(52, 132);
            textBoxDescripcion.Margin = new Padding(3, 4, 3, 4);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(512, 78);
            textBoxDescripcion.TabIndex = 35;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.Location = new Point(308, 62);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(256, 34);
            textBoxNombre.TabIndex = 34;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodigo.Location = new Point(52, 62);
            textBoxCodigo.Margin = new Padding(3, 4, 3, 4);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(250, 34);
            textBoxCodigo.TabIndex = 33;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(52, 219);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 50);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(908, 219);
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
            btnAgregar.Location = new Point(774, 219);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(128, 51);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormRuedas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1089, 673);
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
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRuedas).EndInit();
            ((System.ComponentModel.ISupportInitialize)accesorioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSuletos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBolsas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource accesorioBindingSource;
        private Panel panelGrid;
        private TextBox textBoxBuscar;
        private DataGridView dataGridViewRuedas;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadSueltaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadBolsasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
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
    }
}