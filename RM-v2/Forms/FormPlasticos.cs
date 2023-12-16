using RM_v2.Objects;
using System.Data;

namespace RM_v2.Forms
{
    public partial class FormPlasticos : Form
    {
        List<Accesorio> accesorios = new List<Accesorio>();
        List<Accesorio> accesoriosGrid = new List<Accesorio>();
        int indice = -1;
        bool editando = false;

        private void ActualizarGrilla()
        {
            dataGridViewPlasticos.DataSource = null;
            dataGridViewPlasticos.DataSource = accesoriosGrid;
        }
        private void LimpiarCampos()
        {
            textBoxCodigo.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxDescripcion.Text = string.Empty;
            numericBolsas.Value = 0;
            numericSuletos.Value = 0;
        }
        public FormPlasticos()
        {
            InitializeComponent();
            accesorios = ModuloForms.LeerArchivo();
            accesoriosGrid = accesorios.Where(a => a.Categoria == EnumCategorias.Plastico).ToList();
            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<string> Errores = ModuloForms.ValidarDatos(textBoxCodigo.Text,textBoxNombre.Text,textBoxDescripcion.Text,numericBolsas.Value,numericSuletos.Value);
            if (Errores.Count != 0)
            {
                foreach (string E in Errores)
                    MessageBox.Show(E);
                return;
            }
            if (!editando)
            {
                //Accesorio acc = new Accesorio(textBoxCodigo.Text, textBoxNombre.Text, Convert.ToInt16(numericSuletos.Value), Convert.ToInt16(numericBolsas.Value), textBoxDescripcion.Text, EnumCategorias.Plastico);
                //accesorios.Add(acc);
                //ActualizarGrilla();
            }
            else if (editando)
            {
                //Accesorio m = new Accesorio(textBoxCodigo.Text, textBoxNombre.Text, Convert.ToInt16(numericSuletos.Value), Convert.ToInt16(numericBolsas.Value), textBoxDescripcion.Text, EnumCategorias.Plastico);
                //accesorios[indice] = m;
                //btnAgregar.Text = "Agregar";
            }

            accesoriosGrid = accesorios.Where(a => a.Categoria == EnumCategorias.Plastico).ToList();
            LimpiarCampos();
            ActualizarGrilla();
        }

        private void FormPlasticos_FormClosing(object sender, FormClosingEventArgs e)
        {
            ModuloForms.EscribirLista(accesorios);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            editando = false;
            btnAgregar.Text = "Agregar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlasticos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe seleccionar un elemento");
            }

            else if (MessageBox.Show("¿Seguro que quiere eliminar a este elemento?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                accesorios.Remove(accesorios.Where(a => a.Codigo == dataGridViewPlasticos.CurrentRow.Cells[0].Value.ToString()).SingleOrDefault());
                accesoriosGrid = accesorios.Where(a => a.Categoria == EnumCategorias.Plastico).ToList();
                LimpiarCampos();
                ActualizarGrilla();
            }
        }
        private void dataGridViewPlasticos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editando = true;
            indice = dataGridViewPlasticos.SelectedRows[0].Index;
            textBoxCodigo.Text = accesorios[indice].Codigo;
            textBoxDescripcion.Text = accesorios[indice].Descripcion;
            textBoxNombre.Text = accesorios[indice].Nombre;
            numericBolsas.Value = accesorios[indice].CantidadBolsas;
            numericSuletos.Value = accesorios[indice].CantidadSuelta;
            btnAgregar.Text = "Actualizar";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (string.IsNullOrWhiteSpace(textBoxBuscar.Text.Trim()))
            {
                accesoriosGrid = accesorios.Where(a => a.Categoria == EnumCategorias.Plastico).ToList();
            }
            else if (int.TryParse(textBoxBuscar.Text.Trim(), out n))
            {
                accesoriosGrid = accesorios.Where(a => a.Categoria == EnumCategorias.Plastico).ToList().Where(b => b.Codigo.Contains(textBoxBuscar.Text.Trim().ToUpper()) || b.Nombre.Contains(textBoxBuscar.Text.Trim()) || b.Descripcion.Contains(textBoxBuscar.Text.Trim()) || b.CantidadBolsas == n || b.CantidadSuelta == n).ToList();

            }
            else
            {
                accesoriosGrid = accesorios.Where(a => a.Categoria == EnumCategorias.Plastico).ToList().Where(b => b.Codigo.Contains(textBoxBuscar.Text.Trim().ToUpper()) || b.Nombre.Contains(textBoxBuscar.Text.Trim()) || b.Descripcion.Contains(textBoxBuscar.Text.Trim()) ).ToList();
            }
            ActualizarGrilla();
        }

        private void textBoxBuscar_Enter(object sender, EventArgs e)
        {
            if(textBoxBuscar.Text.Trim() == "Buscar...")
            {
                textBoxBuscar.Text = "";
                textBoxBuscar.ForeColor = Color.Black;
            }
        }

        private void textBoxBuscar_Leave(object sender, EventArgs e)
        {
            if(textBoxBuscar.Text.Trim() == "")
            {
                textBoxBuscar.Text = "Buscar...";
                textBoxBuscar.ForeColor = Color.Silver;
            }
            accesoriosGrid = accesorios.Where(a => a.Categoria == EnumCategorias.Plastico).ToList();
            ActualizarGrilla();
        }
    }
}
