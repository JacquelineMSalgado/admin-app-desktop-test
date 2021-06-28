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
    public partial class VentasTopView : Form
    {
        ProductsController controllerProduct = new ProductsController();
        private ProductModel[] topNumeroVentas;
        private ProductModel[] topVentas;

        private List<string> Producto = new List<string>();
        private List<float> Unidades = new List<float>();

        private List<string> TopProducto = new List<string>();
        private List<float> Ventas = new List<float>();

        public VentasTopView()
        {
            InitializeComponent();
        }

        private void getTopNumeroVentas()
        {
            var response = controllerProduct.getTopNumeroVentas();
            topNumeroVentas = response.ToArray();
        }

        private void getTopVentas()
        {
            var response = controllerProduct.getTopVentas();
            topVentas = response.ToArray();
        }

        public void generarDataChartTopNumeroVentas()
        {
            for (var i = 0; i < topNumeroVentas.Length; i++)
            {
                Producto.Add(topNumeroVentas[i].Titulo);
                Unidades.Add(topNumeroVentas[i].Total);
            }
            chart1.Series[0].Points.DataBindXY(Producto, Unidades);
        }

        public void generarDataChartTopVentas()
        {
            for (var i = 0; i < topVentas.Length; i++)
            {
                TopProducto.Add(topVentas[i].Titulo);
                Ventas.Add(topVentas[i].Total);
            }
            chart2.Series[0].Points.DataBindXY(TopProducto, Ventas);
        }

        private void VentasTopView_Load(object sender, EventArgs e)
        {
            getTopNumeroVentas();
            getTopVentas();
            generarDataChartTopNumeroVentas();
            generarDataChartTopVentas();
        }
    }
}
