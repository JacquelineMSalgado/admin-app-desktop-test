namespace desktop_application.Views
{
    partial class DashboardView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            this.PanelHerramientas = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.ibtnMax = new FontAwesome.Sharp.IconButton();
            this.ibtnClose = new FontAwesome.Sharp.IconButton();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ibtnStock = new FontAwesome.Sharp.IconButton();
            this.ibtnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.ibtnTop = new FontAwesome.Sharp.IconButton();
            this.ibtnVentas = new FontAwesome.Sharp.IconButton();
            this.ibtnProductos = new FontAwesome.Sharp.IconButton();
            this.ibtnInicio = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.PanelChildView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.PanelHerramientas.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContenido.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHerramientas
            // 
            this.PanelHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.PanelHerramientas.Controls.Add(this.iconButton3);
            this.PanelHerramientas.Controls.Add(this.ibtnMax);
            this.PanelHerramientas.Controls.Add(this.ibtnClose);
            this.PanelHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHerramientas.Location = new System.Drawing.Point(0, 0);
            this.PanelHerramientas.Name = "PanelHerramientas";
            this.PanelHerramientas.Size = new System.Drawing.Size(1300, 44);
            this.PanelHerramientas.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(1168, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(44, 44);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // ibtnMax
            // 
            this.ibtnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnMax.FlatAppearance.BorderSize = 0;
            this.ibtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.ibtnMax.IconColor = System.Drawing.Color.White;
            this.ibtnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMax.IconSize = 20;
            this.ibtnMax.Location = new System.Drawing.Point(1212, 0);
            this.ibtnMax.Name = "ibtnMax";
            this.ibtnMax.Size = new System.Drawing.Size(44, 44);
            this.ibtnMax.TabIndex = 1;
            this.ibtnMax.UseVisualStyleBackColor = true;
            this.ibtnMax.Click += new System.EventHandler(this.ibtnMax_Click);
            // 
            // ibtnClose
            // 
            this.ibtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnClose.FlatAppearance.BorderSize = 0;
            this.ibtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ibtnClose.IconColor = System.Drawing.Color.White;
            this.ibtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClose.IconSize = 20;
            this.ibtnClose.Location = new System.Drawing.Point(1256, 0);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(44, 44);
            this.ibtnClose.TabIndex = 0;
            this.ibtnClose.UseVisualStyleBackColor = true;
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.PanelMenu.Controls.Add(this.ibtnStock);
            this.PanelMenu.Controls.Add(this.ibtnCerrarSesion);
            this.PanelMenu.Controls.Add(this.ibtnTop);
            this.PanelMenu.Controls.Add(this.ibtnVentas);
            this.PanelMenu.Controls.Add(this.ibtnProductos);
            this.PanelMenu.Controls.Add(this.ibtnInicio);
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 44);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(176, 606);
            this.PanelMenu.TabIndex = 1;
            // 
            // ibtnStock
            // 
            this.ibtnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnStock.FlatAppearance.BorderSize = 0;
            this.ibtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnStock.ForeColor = System.Drawing.Color.White;
            this.ibtnStock.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.ibtnStock.IconColor = System.Drawing.Color.White;
            this.ibtnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnStock.IconSize = 32;
            this.ibtnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnStock.Location = new System.Drawing.Point(0, 317);
            this.ibtnStock.Name = "ibtnStock";
            this.ibtnStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnStock.Size = new System.Drawing.Size(176, 54);
            this.ibtnStock.TabIndex = 6;
            this.ibtnStock.Text = "Stock";
            this.ibtnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnStock.UseVisualStyleBackColor = true;
            this.ibtnStock.Click += new System.EventHandler(this.ibtnStock_Click);
            // 
            // ibtnCerrarSesion
            // 
            this.ibtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.ibtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.ibtnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.ibtnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCerrarSesion.IconSize = 32;
            this.ibtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCerrarSesion.Location = new System.Drawing.Point(0, 552);
            this.ibtnCerrarSesion.Name = "ibtnCerrarSesion";
            this.ibtnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnCerrarSesion.Size = new System.Drawing.Size(176, 54);
            this.ibtnCerrarSesion.TabIndex = 5;
            this.ibtnCerrarSesion.Text = "Cerrar sesión";
            this.ibtnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCerrarSesion.UseVisualStyleBackColor = true;
            this.ibtnCerrarSesion.Click += new System.EventHandler(this.ibtnCerrarSesion_Click);
            // 
            // ibtnTop
            // 
            this.ibtnTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnTop.FlatAppearance.BorderSize = 0;
            this.ibtnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnTop.ForeColor = System.Drawing.Color.White;
            this.ibtnTop.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.ibtnTop.IconColor = System.Drawing.Color.White;
            this.ibtnTop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTop.IconSize = 32;
            this.ibtnTop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTop.Location = new System.Drawing.Point(0, 263);
            this.ibtnTop.Name = "ibtnTop";
            this.ibtnTop.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnTop.Size = new System.Drawing.Size(176, 54);
            this.ibtnTop.TabIndex = 4;
            this.ibtnTop.Text = "Top";
            this.ibtnTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTop.UseVisualStyleBackColor = true;
            this.ibtnTop.Click += new System.EventHandler(this.ibtnTop_Click);
            // 
            // ibtnVentas
            // 
            this.ibtnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnVentas.FlatAppearance.BorderSize = 0;
            this.ibtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnVentas.ForeColor = System.Drawing.Color.White;
            this.ibtnVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.ibtnVentas.IconColor = System.Drawing.Color.White;
            this.ibtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnVentas.IconSize = 32;
            this.ibtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnVentas.Location = new System.Drawing.Point(0, 209);
            this.ibtnVentas.Name = "ibtnVentas";
            this.ibtnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnVentas.Size = new System.Drawing.Size(176, 54);
            this.ibtnVentas.TabIndex = 3;
            this.ibtnVentas.Text = "Ventas";
            this.ibtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnVentas.UseVisualStyleBackColor = true;
            this.ibtnVentas.Click += new System.EventHandler(this.ibtnVentas_Click);
            // 
            // ibtnProductos
            // 
            this.ibtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnProductos.FlatAppearance.BorderSize = 0;
            this.ibtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnProductos.ForeColor = System.Drawing.Color.White;
            this.ibtnProductos.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.ibtnProductos.IconColor = System.Drawing.Color.White;
            this.ibtnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnProductos.IconSize = 32;
            this.ibtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnProductos.Location = new System.Drawing.Point(0, 155);
            this.ibtnProductos.Name = "ibtnProductos";
            this.ibtnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnProductos.Size = new System.Drawing.Size(176, 54);
            this.ibtnProductos.TabIndex = 2;
            this.ibtnProductos.Text = "Productos";
            this.ibtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnProductos.UseVisualStyleBackColor = true;
            this.ibtnProductos.Click += new System.EventHandler(this.ibtnProductos_Click);
            // 
            // ibtnInicio
            // 
            this.ibtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.ibtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnInicio.FlatAppearance.BorderSize = 0;
            this.ibtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnInicio.ForeColor = System.Drawing.Color.White;
            this.ibtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnInicio.IconColor = System.Drawing.Color.White;
            this.ibtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInicio.IconSize = 32;
            this.ibtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnInicio.Location = new System.Drawing.Point(0, 101);
            this.ibtnInicio.Name = "ibtnInicio";
            this.ibtnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnInicio.Size = new System.Drawing.Size(176, 54);
            this.ibtnInicio.TabIndex = 1;
            this.ibtnInicio.Text = "Inicio";
            this.ibtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnInicio.UseVisualStyleBackColor = false;
            this.ibtnInicio.Click += new System.EventHandler(this.ibtnInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pictureBox1.Size = new System.Drawing.Size(176, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            this.PanelContenido.Controls.Add(this.PanelChildView);
            this.PanelContenido.Controls.Add(this.panel1);
            this.PanelContenido.Controls.Add(this.PanelTitulo);
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(176, 44);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(1124, 606);
            this.PanelContenido.TabIndex = 2;
            // 
            // PanelChildView
            // 
            this.PanelChildView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChildView.Location = new System.Drawing.Point(0, 65);
            this.PanelChildView.Name = "PanelChildView";
            this.PanelChildView.Size = new System.Drawing.Size(1124, 541);
            this.PanelChildView.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 23);
            this.panel1.TabIndex = 1;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Controls.Add(this.iconButton1);
            this.PanelTitulo.Controls.Add(this.lblCurrentChildForm);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1124, 42);
            this.PanelTitulo.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.iconButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton1.Size = new System.Drawing.Size(977, 42);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "¡Bienvenido!";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // lblCurrentChildForm
            // 
            this.lblCurrentChildForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCurrentChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCurrentChildForm.Enabled = false;
            this.lblCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.lblCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentChildForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.lblCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.lblCurrentChildForm.IconColor = System.Drawing.Color.Black;
            this.lblCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lblCurrentChildForm.IconSize = 32;
            this.lblCurrentChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentChildForm.Location = new System.Drawing.Point(977, 0);
            this.lblCurrentChildForm.Name = "lblCurrentChildForm";
            this.lblCurrentChildForm.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblCurrentChildForm.Size = new System.Drawing.Size(147, 42);
            this.lblCurrentChildForm.TabIndex = 3;
            this.lblCurrentChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lblCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelHerramientas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardView";
            this.PanelHerramientas.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContenido.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHerramientas;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelContenido;
        private FontAwesome.Sharp.IconButton ibtnClose;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton ibtnMax;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ibtnInicio;
        private FontAwesome.Sharp.IconButton ibtnCerrarSesion;
        private FontAwesome.Sharp.IconButton ibtnTop;
        private FontAwesome.Sharp.IconButton ibtnVentas;
        private FontAwesome.Sharp.IconButton ibtnProductos;
        private FontAwesome.Sharp.IconButton ibtnStock;
        private System.Windows.Forms.Panel PanelTitulo;
        private FontAwesome.Sharp.IconButton lblCurrentChildForm;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel PanelChildView;
        private System.Windows.Forms.Panel panel1;
    }
}