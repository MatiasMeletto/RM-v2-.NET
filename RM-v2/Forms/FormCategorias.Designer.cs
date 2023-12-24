namespace RM_v2.Forms
{
    partial class FormCategorias
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
            dataGridViewEscuadras = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaBindingSource = new BindingSource(components);
            label2 = new Label();
            textBoxNombre = new TextBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEscuadras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.Controls.Add(textBoxBuscar);
            panelGrid.Controls.Add(dataGridViewEscuadras);
            panelGrid.Location = new Point(0, 277);
            panelGrid.Margin = new Padding(3, 4, 3, 4);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1089, 397);
            panelGrid.TabIndex = 31;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBuscar.ForeColor = Color.Silver;
            textBoxBuscar.Location = new Point(52, 29);
            textBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(441, 34);
            textBoxBuscar.TabIndex = 27;
            textBoxBuscar.Text = "Buscar...";
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            textBoxBuscar.Enter += textBoxBuscar_Enter;
            textBoxBuscar.Leave += textBoxBuscar_Leave;
            // 
            // dataGridViewEscuadras
            // 
            dataGridViewEscuadras.AllowUserToAddRows = false;
            dataGridViewEscuadras.AllowUserToDeleteRows = false;
            dataGridViewEscuadras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEscuadras.AutoGenerateColumns = false;
            dataGridViewEscuadras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEscuadras.BackgroundColor = Color.White;
            dataGridViewEscuadras.BorderStyle = BorderStyle.None;
            dataGridViewEscuadras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewEscuadras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEscuadras.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn });
            dataGridViewEscuadras.DataSource = categoriaBindingSource;
            dataGridViewEscuadras.Location = new Point(52, 71);
            dataGridViewEscuadras.Margin = new Padding(3, 4, 3, 4);
            dataGridViewEscuadras.Name = "dataGridViewEscuadras";
            dataGridViewEscuadras.ReadOnly = true;
            dataGridViewEscuadras.RowHeadersWidth = 51;
            dataGridViewEscuadras.RowTemplate.Height = 24;
            dataGridViewEscuadras.Size = new Size(984, 266);
            dataGridViewEscuadras.TabIndex = 26;
            dataGridViewEscuadras.RowHeaderMouseDoubleClick += dataGridViewEscuadras_RowHeaderMouseDoubleClick;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Objects.Categoria);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 43);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 51;
            label2.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.Location = new Point(52, 62);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(250, 34);
            textBoxNombre.TabIndex = 47;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(52, 219);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 50);
            btnLimpiar.TabIndex = 46;
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
            btnEliminar.TabIndex = 45;
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
            btnAgregar.TabIndex = 44;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1089, 673);
            Controls.Add(label2);
            Controls.Add(textBoxNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(panelGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCategorias";
            Text = "FormCategorias";
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEscuadras).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGrid;
        private TextBox textBoxBuscar;
        private DataGridView dataGridViewEscuadras;
        private Label label2;
        private TextBox textBoxNombre;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private BindingSource categoriaBindingSource;
    }
}