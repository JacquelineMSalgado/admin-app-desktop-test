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
    public partial class ProductosView : Form
    {
        ProductsController controllerProduct = new ProductsController();
        private ProductModel[] products;

        private List<string> Producto = new List<string>();
        private List<int> Existencias = new List<int>();

        public ProductosView()
        {
            InitializeComponent();
        }

        private void ProductosView_Load(object sender, EventArgs e)
        {
            getProducts();
            generarDataChartVentas();
        }

        private void getProducts()
        {
            var response = controllerProduct.getAllProducts();
            products = response.ToArray();
            dataGridView1.DataSource = products;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Existencias")
            {
                if(Convert.ToInt16(e.Value) < 100)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        public void generarDataChartVentas()
        {
            for (var i = 0; i < products.Length; i++)
            {
                Producto.Add(products[i].Titulo);
                Existencias.Add(products[i].Existencias);
            }
            chtExistencias.Series[0].Points.DataBindXY(Producto, Existencias);
        }
    }
}
