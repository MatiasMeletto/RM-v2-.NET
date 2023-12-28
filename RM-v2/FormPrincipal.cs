using System;
using RM_v2;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RM_v2.Forms;
using RM_v2.Data.Models;
using RM_v2.Objects;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;

namespace RM_v2
{
    public partial class FormPrincipal : Form
    {
        private Button btnActual = null;
        private Form formularioActivo = null;
        private List<Button> categorias = new();
        private Categoria c;

        public FormPrincipal()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            LoadForm();
        }
        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            this.Close();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            using var _dbContext = new StockingDbContext();
            if (formularioActivo != null)
                formularioActivo.Close();
            else
                return;
            panelDecorativo.Location = new Point(0,94);
            panelDecorativo.Height = 50 * categorias.Count();
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
        }
        public async void LoadForm()
        {
            using var _dbContext = new StockingDbContext();
            categorias = ModuloPrincipal.CargarCategorias(await _dbContext.categorias.ToListAsync());
            panelSeleccion.Controls.Clear();
            panelDecorativo.Height = 50 * await _dbContext.categorias.CountAsync();
            foreach (var categoria in categorias)
            {
                panelSeleccion.Controls.Add(categoria);
                categoria.Click += new EventHandler(AbrirForm);
            }
        }
        private async void AbrirForm(object sender, EventArgs e)
        {
            using var _dbContext = new StockingDbContext();
            Button button = sender as Button;
            c = await _dbContext.categorias.Where(c => c.Nombre == button.Text).SingleOrDefaultAsync();
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
            btnActual = ModuloPrincipal.PreAbrir(panelDecorativo, btnActual, button);
            formularioActivo = ModuloPrincipal.AbrirFormularioHijo(panelGrid, formularioActivo, new FormAccesorios(c));
        }

        private async void btnCategorias_Click(object sender, EventArgs e)
        {
            using var _dbContext = new StockingDbContext();
            formularioActivo = ModuloPrincipal.AbrirFormularioHijo(panelGrid, formularioActivo, new FormCategorias(this));
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
            panelDecorativo.Location = new Point(0, 94);
            panelDecorativo.Height = 50 * await _dbContext.categorias.CountAsync(); ;
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
        }
    }
}
