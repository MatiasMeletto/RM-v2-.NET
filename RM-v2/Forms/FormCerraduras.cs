using Microsoft.EntityFrameworkCore;
using RM_v2.Data.Models;
using RM_v2.Objects;
using System.Data;

namespace RM_v2.Forms
{
    public partial class FormCerraduras : Form
    {
        Accesorio[]? accesorios;
        int indice = -1;
        bool editando = false;
        string codigoEditado;

        private async void ActualizarGrilla()
        {
            using var _dbContext = new StockingDbContext();
            accesorios = await _dbContext.accesorios.Where(a => a.Categoria == EnumCategorias.Cerradura).ToArrayAsync();
            if (accesorios is not null)
            {
                dataGridViewCerradura.DataSource = null;
                dataGridViewCerradura.DataSource = accesorios;
            }
        }
        private void LimpiarCampos()
        {
            codigoEditado = string.Empty;
            textBoxCodigo.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxDescripcion.Text = string.Empty;
            numericBolsas.Value = 0;
            numericSuletos.Value = 0;
            indice = -1;
        }
        public FormCerraduras()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Task.Run(() =>
            {
                ActualizarGrilla();
            });
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            List<string> Errores = ModuloForms.ValidarDatos(textBoxCodigo.Text, textBoxNombre.Text, textBoxDescripcion.Text, numericBolsas.Value, numericSuletos.Value);
            if (Errores.Count != 0)
            {
                foreach (string E in Errores)
                    MessageBox.Show(E);
                return;
            }
            else
            {
                using var _dbContext = new StockingDbContext();

                if (accesorios is not null)
                {
                    if (!editando)
                    {
                        foreach (Accesorio a in accesorios)
                        {
                            if (a.Codigo == textBoxCodigo.Text.ToUpper())
                            {
                                MessageBox.Show("El codigo ya existe");
                                return;
                            }
                        }
                        Accesorio accesorio = new Accesorio()
                        {
                            Codigo = textBoxCodigo.Text,
                            Nombre = textBoxNombre.Text,
                            CantidadBolsas = Convert.ToInt16(numericBolsas.Value),
                            CantidadSuelta = Convert.ToInt16(numericSuletos.Value),
                            Descripcion = textBoxDescripcion.Text,
                            Categoria = EnumCategorias.Cerradura,
                        };
                        _dbContext.accesorios.Add(accesorio);
                        _dbContext.SaveChanges();
                    }
                    else if (editando)
                    {
                        foreach (Accesorio a in accesorios)
                        {
                            if (a.Codigo == textBoxCodigo.Text.ToUpper() && textBoxCodigo.Text.ToUpper() != codigoEditado)
                            {
                                MessageBox.Show("El codigo ya existe");
                                return;
                            }
                        }
                        Accesorio? acc = _dbContext.accesorios.Where(a => a.Codigo == codigoEditado).SingleOrDefault();

                        if (acc != null)
                        {
                            acc.Nombre = textBoxNombre.Text;
                            acc.Descripcion = textBoxDescripcion.Text;
                            acc.Codigo = textBoxCodigo.Text;
                            acc.CantidadBolsas = Convert.ToInt16(numericBolsas.Value);
                            acc.CantidadSuelta = Convert.ToInt16(numericSuletos.Value);
                        }
                        _dbContext.SaveChanges();
                    }
                    LimpiarCampos();
                    ActualizarGrilla();
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            editando = false;
            btnAgregar.Text = "Agregar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using var _dbContext = new StockingDbContext();

            if (accesorios is not null && indice != -1)
            {
                Accesorio? acc = _dbContext.accesorios.Where(a => a.Codigo == dataGridViewCerradura.CurrentRow.Cells[0].Value.ToString()).SingleOrDefault();
                if (acc is not null)
                {
                    if (dataGridViewCerradura.SelectedRows.Count != 1)
                    {
                        MessageBox.Show("Debe seleccionar un elemento");
                    }

                    else if (MessageBox.Show("¿Seguro que quiere eliminar a este elemento?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _dbContext.accesorios.Remove(acc);
                        _dbContext.SaveChanges();
                        LimpiarCampos();
                        ActualizarGrilla();
                    }
                }
            }
        }

        private void dataGridViewCerraduras_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (accesorios is not null)
            {
                editando = true;
                indice = dataGridViewCerradura.SelectedRows[0].Index;
                textBoxCodigo.Text = accesorios[indice].Codigo;
                textBoxDescripcion.Text = accesorios[indice].Descripcion;
                textBoxNombre.Text = accesorios[indice].Nombre;
                numericBolsas.Value = accesorios[indice].CantidadBolsas;
                numericSuletos.Value = accesorios[indice].CantidadSuelta;
                btnAgregar.Text = "Actualizar";
                codigoEditado = accesorios[indice].Codigo;
            }

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            using var _dbContext = new StockingDbContext();
            int n;
            if (string.IsNullOrWhiteSpace(textBoxBuscar.Text.Trim()))
            {
                ActualizarGrilla();
            }
            else if (int.TryParse(textBoxBuscar.Text.Trim(), out n))
            {
                accesorios = _dbContext.accesorios.Where(a => a.Categoria == EnumCategorias.Cerradura).ToList().Where(b => b.Codigo.Contains(textBoxBuscar.Text.Trim().ToUpper()) || b.Nombre.Contains(textBoxBuscar.Text.Trim()) || b.Descripcion.Contains(textBoxBuscar.Text.Trim()) || b.CantidadBolsas == n || b.CantidadSuelta == n).ToArray();
                if (accesorios is not null)
                {
                    dataGridViewCerradura.DataSource = null;
                    dataGridViewCerradura.DataSource = accesorios;
                }

            }
            else
            {
                accesorios = _dbContext.accesorios.Where(a => a.Categoria == EnumCategorias.Cerradura).ToList().Where(b => b.Codigo.Contains(textBoxBuscar.Text.Trim().ToUpper()) || b.Nombre.Contains(textBoxBuscar.Text.Trim()) || b.Descripcion.Contains(textBoxBuscar.Text.Trim())).ToArray();
                if (accesorios is not null)
                {
                    dataGridViewCerradura.DataSource = null;
                    dataGridViewCerradura.DataSource = accesorios;
                }
            }
        }

        private void textBoxBuscar_Enter(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text.Trim() == "Buscar...")
            {
                textBoxBuscar.Text = "";
                textBoxBuscar.ForeColor = Color.Black;
            }
        }

        private void textBoxBuscar_Leave(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text.Trim() == "")
            {
                textBoxBuscar.Text = "Buscar...";
                textBoxBuscar.ForeColor = Color.Silver;
            }
            ActualizarGrilla();
        }
    }
}
