using desktop_application.Controllers;
using desktop_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace desktop_application.Views
{
    public partial class InicioView : Form
    {
        ProductsController controllerProduct = new ProductsController();
        private ProductModel[] products;
        private VentasModel[] ventasGenerales;
        private ProductModel[] ventasProducto;
        private VentasModel[] ventasMes;
        private List<string> Categoria = new List<string>();
        private List<int> CantidadVentas = new List<int>();
        private List<string> Mes = new List<string>();
        private List<float> CantidadVentasMes = new List<float>();

        public InicioView()
        {
            InitializeComponent();
            getProducts();
            getVentasGenerales();
            getVentasPorProducto();
            getVentasPorMes();
        }

        private void getProducts()
        {
            var response = controllerProduct.getAllProducts();
            products = response.ToArray();
            iconButton1.Text = products.Length + " PRODUCTOS REGISTRADOS";
        }
        
        private void getVentasGenerales()
        {
            var response = controllerProduct.getVentasGenerales();
            ventasGenerales = response.ToArray();
            iconButton2.Text = "+ $" + ventasGenerales[0].Total + " PESOS EN GANANCÍAS";
            iconButton3.Text = ventasGenerales[0].CantidadVendida + " PRODUCTOS VENDIDOS";
        }

        private void getVentasPorProducto()
        {
            var response = controllerProduct.getVentasPorProducto();
            ventasProducto = response.ToArray();
        }

        private void getVentasPorMes()
        {
            var response = controllerProduct.getVentasPorMes();
            ventasMes = response.ToArray();
        }

        private void InicioView_Load(object sender, EventArgs e)
        {
            generarDataChartVentas();
            generarDataChartGanancias();
        }

        public void generarDataChartVentas()
        {
            for (var i = 0; i < ventasProducto.Length; i++)
            {
                Categoria.Add(ventasProducto[i].Titulo);
                CantidadVentas.Add(ventasProducto[i].CantidadVendida);
            }
            chtVentasProducto.Series[0].Points.DataBindXY(Categoria, CantidadVentas);
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
    }
}
