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

namespace RM_v2
{
    public partial class FormPrincipal : Form
    {
        private Button btnActual = null;
        private Form formularioActivo = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            this.Close();
        }
        private void btnBisagras_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
            btnActual = ModuloPrincipal.PreAbrir(panelDecorativo, btnActual, btnBisagras);
            formularioActivo = ModuloPrincipal.AbrirFormularioHijo(panelGrid, formularioActivo, new FormBisagras());
        }
        private void btnEscuadras_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
            btnActual = ModuloPrincipal.PreAbrir(panelDecorativo, btnActual, btnEscuadras);
            formularioActivo = ModuloPrincipal.AbrirFormularioHijo(panelGrid, formularioActivo, new FormEscuadras());
        }
        private void btnPicaportes_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
            btnActual = ModuloPrincipal.PreAbrir(panelDecorativo, btnActual, btnPicaportes);
            formularioActivo = ModuloPrincipal.AbrirFormularioHijo(panelGrid, formularioActivo, new FormPicaportes());
        }
        private void btnRuedas_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
            btnActual = ModuloPrincipal.PreAbrir(panelDecorativo, btnActual, btnRuedas);
            formularioActivo = ModuloPrincipal.AbrirFormularioHijo(panelGrid, formularioActivo, new FormRuedas());
        }
        private void btnPlasticos_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
            btnActual = ModuloPrincipal.PreAbrir(panelDecorativo, btnActual, btnPlasticos);
            formularioActivo = ModuloPrincipal.AbrirFormularioHijo(panelGrid, formularioActivo, new FormPlasticos());
        }
        private void btnCerraduras_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
            btnActual = ModuloPrincipal.PreAbrir(panelDecorativo, btnActual, btnCerraduras);
            formularioActivo = ModuloPrincipal.AbrirFormularioHijo(panelGrid, formularioActivo, new FormCerraduras());
        }
        private void btnOtros_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
            btnActual = ModuloPrincipal.PreAbrir(panelDecorativo, btnActual, btnOtros);
            formularioActivo = ModuloPrincipal.AbrirFormularioHijo(panelGrid, formularioActivo, new FormOtros());
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            else
                return;
            panelDecorativo.Top = btnBisagras.Top;
            panelDecorativo.Left = btnBisagras.Left;
            panelDecorativo.Height = btnBisagras.Height + btnCerraduras.Height + btnEscuadras.Height + btnOtros.Height + btnPicaportes.Height + btnPlasticos.Height + btnRuedas.Height - 2;
            if (btnActual != null)
                btnActual = ModuloPrincipal.CambioColor(btnActual, btnActual, false);
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
        }
    }
}
