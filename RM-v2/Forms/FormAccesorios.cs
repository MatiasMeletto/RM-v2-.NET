﻿using Microsoft.EntityFrameworkCore;
using RM_v2.Data.Models;
using RM_v2.Objects;
using System.Data;

namespace RM_v2.Forms
{
    public partial class FormAccesorios : Form
    {
        Accesorio[]? accesorios;
        Categoria? categoria;
        int indice = -1;
        bool editando = false;
        string codigoEditado;

        private async void ActualizarGrilla()
        {
            using var _dbContext = new StockingDbContext();
            accesorios = await _dbContext.accesorios.Where(a => a.Categoria.Nombre == categoria.Nombre).ToArrayAsync();
            if (accesorios is not null)
            {
                dataGridViewAccesorios.DataSource = null;
                dataGridViewAccesorios.DataSource = accesorios;
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
            numericImporte.Value = 0;
            indice = -1;
        }
        public FormAccesorios(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            CheckForIllegalCrossThreadCalls = false;
            Task.Run(() =>
            {
                ActualizarGrilla();
            });
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {

            List<string> Errores = ModuloForms.ValidarDatos(textBoxCodigo.Text, textBoxNombre.Text, textBoxDescripcion.Text, numericBolsas.Value, numericSuletos.Value, numericImporte.Value);
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
                            CategoriaId = (await _dbContext.categorias.Where(c => c.Nombre == categoria.Nombre).SingleOrDefaultAsync()).CategoriaId,
                            Importe = numericImporte.Value
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
                            acc.Importe = numericImporte.Value;
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
                Accesorio? acc = _dbContext.accesorios.Where(a => a.Codigo == dataGridViewAccesorios.CurrentRow.Cells[0].Value.ToString()).SingleOrDefault();
                if (acc is not null)
                {
                    if (dataGridViewAccesorios.SelectedRows.Count != 1)
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

        private void dataGridViewEscuadras_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (accesorios is not null)
            {
                editando = true;
                indice = dataGridViewAccesorios.SelectedRows[0].Index;
                textBoxCodigo.Text = accesorios[indice].Codigo;
                textBoxDescripcion.Text = accesorios[indice].Descripcion;
                textBoxNombre.Text = accesorios[indice].Nombre;
                numericBolsas.Value = accesorios[indice].CantidadBolsas;
                numericSuletos.Value = accesorios[indice].CantidadSuelta;
                numericImporte.Value = accesorios[indice].Importe;
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
                accesorios = _dbContext.accesorios.Where(a => a.Categoria.Nombre == categoria.Nombre).ToList().Where(b => b.Codigo.Contains(textBoxBuscar.Text.Trim().ToUpper()) || b.Nombre.Contains(textBoxBuscar.Text.Trim()) || b.Descripcion.Contains(textBoxBuscar.Text.Trim()) || b.CantidadBolsas == n || b.CantidadSuelta == n || b.Importe == n).ToArray();
                if (accesorios is not null)
                {
                    dataGridViewAccesorios.DataSource = null;
                    dataGridViewAccesorios.DataSource = accesorios;
                }

            }
            else
            {
                accesorios = _dbContext.accesorios.Where(a => a.Categoria.Nombre == categoria.Nombre).ToList().Where(b => b.Codigo.Contains(textBoxBuscar.Text.Trim().ToUpper()) || b.Nombre.Contains(textBoxBuscar.Text.Trim()) || b.Descripcion.Contains(textBoxBuscar.Text.Trim())).ToArray();
                if (accesorios is not null)
                {
                    dataGridViewAccesorios.DataSource = null;
                    dataGridViewAccesorios.DataSource = accesorios;
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
