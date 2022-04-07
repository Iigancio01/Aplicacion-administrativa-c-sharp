using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using appPrimer.Interfaz_de_usuario;

namespace appPrimer
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Codigo para poder mover la ventana con el panel de la parte de arriba
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
             
            login.Show();

            this.Hide();
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.PanelCentral.Controls.Count > 0)
                this.PanelCentral.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelCentral.Controls.Add(fh);
            this.PanelCentral.Tag = fh;
            fh.Show();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new NuevaFicha());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Productos());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Inicio());
        }

       
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new GenerarFactura());
            
        }

        private void btnGenerarBoleta_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new GenerarBoleta());
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ListaClientes());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Modificar());
        }
    }
}
