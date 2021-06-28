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
    public partial class StockView : Form
    {
        ProductsController controllerProduct = new ProductsController();
        private ProductModel[] products;

        public StockView()
        {
            InitializeComponent();
        }

        private void StockView_Load(object sender, EventArgs e)
        {
            getProducts();
        }

        private void getProducts()
        {
            var response = controllerProduct.getStock();
            products = response.ToArray();
            dataGridView1.DataSource = products;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }
    }
}
