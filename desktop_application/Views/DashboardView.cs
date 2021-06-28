using FontAwesome.Sharp;
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
    public partial class DashboardView : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildView;

        public DashboardView()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(9, 54);
            PanelMenu.Controls.Add(leftBorderBtn);
            ActivateButton(ibtnInicio);

            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            OpenChildViews(new InicioView());
        }

        public void OpenChildViews(Form childForm)
        {
            if(currentChildView != null)
            {
                currentChildView.Close();
            }

            currentChildView = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildView.Controls.Add(childForm);
            PanelChildView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(51, 117, 209);
                currentBtn.ForeColor = Color.FromArgb(196, 223, 246);
                currentBtn.IconColor = Color.FromArgb(196, 223, 246);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = Color.FromArgb(196, 223, 246);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                lblCurrentChildForm.IconChar = currentBtn.IconChar;
                lblCurrentChildForm.IconColor = Color.FromArgb(0, 17, 44);
                lblCurrentChildForm.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 17, 44);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibtnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                ibtnMax.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            } else
            {
                WindowState = FormWindowState.Normal;
                ibtnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
        }

        private void ibtnInicio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildViews(new InicioView());
        }

        private void ibtnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildViews(new ProductosView());
        }

        private void ibtnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildViews(new VentasView());
        }

        private void ibtnTop_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildViews(new VentasTopView());
        }

        private void ibtnStock_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildViews(new StockView());
        }

        private void ibtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Hide();
            InicioSesionView iniciosesion = new InicioSesionView();
            iniciosesion.Show();
        }
    }
}
