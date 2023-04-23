using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCT_RH
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
      
        int m, mx, my;
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AbrirEmpleado = new FORMS.Empleado();
            AbrirEmpleado.Show();
            
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AbrirEmpleado = new FORMS.AltaEmpleados();
            AbrirEmpleado.Show();
        }

        private void MenuDesplegableBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuDesplegableBtn_Click_1(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                contenedorMenuPnl.Width = 90;
                linea.Width = 252;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                contenedorMenuPnl.Width = 300;
                linea.Width = 252;
                AnimacionSidebarAtras.Show(Sidebar);
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registrarbtn_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FORMS.AltaEmpleados());
        }

        private void modiifcarBTN_Click(object sender, EventArgs e)
        {
            AbrirFormHijo2(new FORMS.Modificar());
        }
        private void AbrirFormHijo(object formhijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }
        private void AbrirFormHijo2(object formhijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FORMS.EliminarEmpleado());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuTopPnl_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }

        private void menuTopPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);

        }

        private void menuTopPnl_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
