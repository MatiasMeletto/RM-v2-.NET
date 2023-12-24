using Microsoft.EntityFrameworkCore;
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
    public partial class FormCategorias : Form
    {
        Categoria[]? categorias;
        int indice = -1;
        bool editando = false;
        string? nombreEditado;
        private FormPrincipal f;

        private async void ActualizarGrilla()
        {
            using var _dbContext = new StockingDbContext();
            categorias = await _dbContext.categorias.ToArrayAsync();
            if (categorias is not null)
            {
                dataGridViewEscuadras.DataSource = null;
                dataGridViewEscuadras.DataSource = categorias;
            }
        }
        private void LimpiarCampos()
        {
            nombreEditado = string.Empty;
            textBoxNombre.Text = string.Empty;
            indice = -1;
        }
        public FormCategorias(FormPrincipal f)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Task.Run(() =>
            {
                ActualizarGrilla();
            });
            this.f = f;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxNombre.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            else
            {
                using var _dbContext = new StockingDbContext();

                if (categorias is not null)
                {
                    if (!editando)
                    {
                        foreach (Categoria a in categorias)
                        {
                            if (a.Nombre == textBoxNombre.Text)
                            {
                                MessageBox.Show("El codigo ya existe");
                                return;
                            }
                        }
                        Categoria categoria = new Categoria()
                        {
                            Nombre = textBoxNombre.Text
                        };
                        await _dbContext.categorias.AddAsync(categoria);
                    }
                    else if (editando)
                    {
                        foreach (Categoria a in categorias)
                        {
                            if (a.Nombre == textBoxNombre.Text && textBoxNombre.Text != nombreEditado)
                            {
                                MessageBox.Show("El codigo ya existe");
                                return;
                            }
                        }
                        Categoria? c = _dbContext.categorias.Where(a => a.Nombre == nombreEditado).SingleOrDefault();

                        if (c != null)
                        {
                            c.Nombre = textBoxNombre.Text;
                        }
                    }
                    await _dbContext.SaveChangesAsync();
                    btnAgregar.Text = "Agregar";
                    LimpiarCampos();
                    ActualizarGrilla();
                    ActualizarCategorias(f);
                }
            }
        }
        private void ActualizarCategorias(FormPrincipal formPrincipal)
        {
            formPrincipal.LoadForm();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            editando = false;
            btnAgregar.Text = "Agregar";
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            using var _dbContext = new StockingDbContext();

            if (categorias is not null && indice != -1)
            {
                Categoria? c = await _dbContext.categorias.Where(a => a.Nombre == dataGridViewEscuadras.CurrentRow.Cells[0].Value.ToString()).SingleOrDefaultAsync();
                if (c is not null)
                {
                    if (dataGridViewEscuadras.SelectedRows.Count != 1)
                    {
                        MessageBox.Show("Debe seleccionar un elemento");
                    }

                    else if (MessageBox.Show("¿Seguro que quiere eliminar a este elemento?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _dbContext.categorias.Remove(c);
                        await _dbContext.SaveChangesAsync();
                        LimpiarCampos();
                        editando = false;
                        btnAgregar.Text = "Agregar";
                        ActualizarGrilla();
                        ActualizarCategorias(f);
                    }
                }
            }
        }

        private void dataGridViewEscuadras_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (categorias is not null)
            {
                editando = true;
                indice = dataGridViewEscuadras.SelectedRows[0].Index;
                textBoxNombre.Text = categorias[indice].Nombre;
                btnAgregar.Text = "Actualizar";
                nombreEditado = categorias[indice].Nombre;
            }

        }

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            using var _dbContext = new StockingDbContext();
            int n;
            if (string.IsNullOrWhiteSpace(textBoxBuscar.Text.Trim()))
            {
                ActualizarGrilla();
            }
            else if (int.TryParse(textBoxBuscar.Text.Trim(), out n))
            {
                categorias = await _dbContext.categorias.Where(c => c.Nombre == textBoxNombre.Text).ToArrayAsync();
                if (categorias is not null)
                {
                    dataGridViewEscuadras.DataSource = null;
                    dataGridViewEscuadras.DataSource = categorias;
                }

            }
            else
            {
                categorias = await _dbContext.categorias.Where(c => c.Nombre == textBoxNombre.Text).ToArrayAsync();
                if (categorias is not null)
                {
                    dataGridViewEscuadras.DataSource = null;
                    dataGridViewEscuadras.DataSource = categorias;
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
