using desktop_application.Controllers;
using desktop_application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_application.Views
{
    public partial class InicioSesionView : Form
    {
        InicioSesionController controllerInicioSesion = new InicioSesionController();

        public InicioSesionView()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://my.indeed.com/p/0nveg7m");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (controllerInicioSesion.validarEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("El formato de correo ingresado no es correcto. Ingresa un correo valido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtEmail.Focus();
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (controllerInicioSesion.validarContrasenia(txtContrasenia.Text) == false)
            {
                MessageBox.Show("La contraseña debe tener al menos ocho carácteres, una letra, un número y un carácter especial.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtContrasenia.Focus();
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (controllerInicioSesion.validarEmail(txtEmail.Text) == true && controllerInicioSesion.validarContrasenia(txtContrasenia.Text) == true)
            {
                var usuario = new UsuarioModel();
                usuario.email = txtEmail.Text; usuario.contrasenia = txtContrasenia.Text;

                btnAcceder.BackColor = Color.FromArgb(0, 17, 44);

                if(controllerInicioSesion.validarSesion(usuario))
                {
                    Hide();
                    DashboardView dashboard = new DashboardView();
                    dashboard.Show();
                } else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta, favor de revisar tus datos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("El formulario aún no es valido, favor de llenar los datos correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
