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
    public partial class VentasView : Form
    {
        ProductsController controllerProduct = new ProductsController();
        private VentasModel[] ventas;
        private ProductModel[] ventasProducto;

        private List<string> Producto = new List<string>();
        private List<float> Ventas = new List<float>();
        private VentasModel[] ventasMes;

        private List<string> Mes = new List<string>();
        private List<float> CantidadVentasMes = new List<float>();
        private ProductModel[] ventasProductoMes;

        public VentasView()
        {
            InitializeComponent();
        }

        private void getVentasPorProducto()
        {
            var response = controllerProduct.getVentasPorProducto();
            ventasProducto = response.ToArray();
            dataGridView2.DataSource = ventasProducto;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[7].Visible = false;
        }

        private void getVentasPorMes()
        {
            var response = controllerProduct.getVentasPorMes();
            ventasMes = response.ToArray();
            dataGridView1.DataSource = ventasMes;
            dataGridView1.Columns[0].Visible = false;
        }

        private void getVentasPorProductoMes()
        {
            var response = controllerProduct.getVentasPorProductoMes();
            ventasProductoMes = response.ToArray();
            dataGridView3.DataSource = ventasProductoMes;
            dataGridView3.Columns[2].Visible = false;
            dataGridView3.Columns[4].Visible = false;
            dataGridView3.Columns[6].Visible = false;
        }

        public void generarDataChartVentas()
        {
            for (var i = 0; i < ventasProducto.Length; i++)
            {
                Producto.Add(ventasProducto[i].Titulo);
                Ventas.Add(ventasProducto[i].Total);
            }
            chtVentasProducto.Series[0].Points.DataBindXY(Producto, Ventas);
        }

        public void generarDataChartGanancias()
        {
            for (var i = 0; i < ventasMes.Length; i++)
            {
                Mes.Add(ventasMes[i].Mes);
                CantidadVentasMes.Add(ventasMes[i].Total);
            }
            chtVentasMes.Series[0].Points.DataBindXY(Mes, CantidadVentasMes);
        }

        private void VentasView_Load(object sender, EventArgs e)
        {
            getVentasPorProducto();
            generarDataChartVentas();
            getVentasPorMes();
            generarDataChartGanancias();
            getVentasPorProductoMes();
        }
    }
}
