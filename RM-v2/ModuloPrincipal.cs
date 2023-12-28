using RM_v2.Objects;

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
            panelNav.Location = new Point(btn.Location.X,btn.Location.Y+94);
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

        public static List<Button> CargarCategorias(List<Categoria> categorias)
        {
            List<Button> list = new List<Button>();
            foreach (Categoria c in categorias)
            {
                Button button = new Button
                {
                    Width = 173,
                    Height = 50,
                    Location = new Point(0, 50 * categorias.IndexOf(c)),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.DarkSlateGray,
                    ForeColor = Color.FromArgb(192,255,255),
                    Text = c.Nombre,
                    Name = "Boton" + c.Nombre
                    
                };
                button.FlatAppearance.BorderSize = 0;
                button.BringToFront();
                button.Show();
                list.Add(button);
            }
            return list;
        }
    }
}
