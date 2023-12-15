namespace RM_v2
{
    public class ModuloPrincipal
    {
        public static Button CambioColor(Button act, Button button, bool seleccionado)
        {
            if (seleccionado)
            {
                button.BackColor = Color.FromArgb(50, 120, 120);
                return button;
            }
            else
                button.BackColor = Color.FromArgb(47, 79, 79);
                return act;
        }
        public static Button PreAbrir(Panel panelNav, Button act, Button btn)
        {
            panelNav.Height = btn.Height;
            panelNav.Top = btn.Top;
            panelNav.Left = btn.Left;
            return CambioColor(act, btn, true);
        }
        public static Form AbrirFormularioHijo(Panel panel, Form formAct, Form form)
        {
            if (formAct != null)
                formAct.Close();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.BringToFront();
            form.Show();
            return form;
        }
    }
}
