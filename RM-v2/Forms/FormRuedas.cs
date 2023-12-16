using RM_v2.Data.Models;
using RM_v2.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_v2.Forms
{
    public partial class FormRuedas : Form
    {
        Accesorio[]? accesorios;
        int indice = -1;
        bool editando = false;

        private void ActualizarGrilla()
        {
            using var _dbContext = new StockingDbContext();
            accesorios = _dbContext.accesorios.Where(a => a.Categoria == EnumCategorias.Rueda).ToArray();
            if (accesorios is not null)
            {
                dataGridViewRuedas.DataSource = null;
                dataGridViewRuedas.DataSource = accesorios;
            }
        }
        private void LimpiarCampos()
        {
            textBoxCodigo.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxDescripcion.Text = string.Empty;
            numericBolsas.Value = 0;
            numericSuletos.Value = 0;
        }
        public FormRuedas()
        {
            InitializeComponent();
            ActualizarGrilla();
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
                    foreach (Accesorio a in accesorios)
                    {
                        if (a.Codigo == textBoxCodigo.Text.ToUpper())
                        {
                            MessageBox.Show("El codigo ya existe");
                            return;
                        }
                    }
                    if (!editando)
                    {
                        Accesorio accesorio = new Accesorio()
                        {
                            Codigo = textBoxCodigo.Text,
                            Nombre = textBoxNombre.Text,
                            CantidadBolsas = Convert.ToInt16(numericBolsas.Value),
                            CantidadSuelta = Convert.ToInt16(numericSuletos.Value),
                            Descripcion = textBoxDescripcion.Text,
                            Categoria = EnumCategorias.Rueda,
                        };
                        _dbContext.accesorios.Add(accesorio);
                        _dbContext.SaveChanges();
                    }
                    else if (editando)
                    {
                        Accesorio? acc = _dbContext.accesorios.Where(a => a.Codigo == textBoxCodigo.Text.ToUpper()).SingleOrDefault();

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

            if (accesorios is not null)
            {
                Accesorio? acc = _dbContext.accesorios.Where(a => a.Codigo == dataGridViewRuedas.CurrentRow.Cells[0].Value.ToString()).SingleOrDefault();
                if (acc is not null)
                {
                    if (dataGridViewRuedas.SelectedRows.Count != 1)
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

        private void dataGridViewRuedas_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (accesorios is not null)
            {
                editando = true;
                indice = dataGridViewRuedas.SelectedRows[0].Index;
                textBoxCodigo.Text = accesorios[indice].Codigo;
                textBoxDescripcion.Text = accesorios[indice].Descripcion;
                textBoxNombre.Text = accesorios[indice].Nombre;
                numericBolsas.Value = accesorios[indice].CantidadBolsas;
                numericSuletos.Value = accesorios[indice].CantidadSuelta;
                btnAgregar.Text = "Actualizar";
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
                accesorios = _dbContext.accesorios.Where(a => a.Categoria == EnumCategorias.Rueda).ToList().Where(b => b.Codigo.Contains(textBoxBuscar.Text.Trim().ToUpper()) || b.Nombre.Contains(textBoxBuscar.Text.Trim()) || b.Descripcion.Contains(textBoxBuscar.Text.Trim()) || b.CantidadBolsas == n || b.CantidadSuelta == n).ToArray();
                if (accesorios is not null)
                {
                    dataGridViewRuedas.DataSource = null;
                    dataGridViewRuedas.DataSource = accesorios;
                }

            }
            else
            {
                accesorios = _dbContext.accesorios.Where(a => a.Categoria == EnumCategorias.Rueda).ToList().Where(b => b.Codigo.Contains(textBoxBuscar.Text.Trim().ToUpper()) || b.Nombre.Contains(textBoxBuscar.Text.Trim()) || b.Descripcion.Contains(textBoxBuscar.Text.Trim())).ToArray();
                if (accesorios is not null)
                {
                    dataGridViewRuedas.DataSource = null;
                    dataGridViewRuedas.DataSource = accesorios;
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
