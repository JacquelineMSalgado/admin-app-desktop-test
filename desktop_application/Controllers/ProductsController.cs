using desktop_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace desktop_application.Controllers
{
    class ProductsController
    {
        public IEnumerable<ProductModel> getAllProducts()
        {
            ApiController.InitializeClient();

            HttpResponseMessage response = ApiController.ApiClient.GetAsync("products").Result;
            var product = response.Content.ReadAsAsync<IEnumerable<ProductModel>>().Result;

            return product;
        }

        public IEnumerable<VentasModel> getVentasGenerales()
        {
            ApiController.InitializeClient();

            HttpResponseMessage response = ApiController.ApiClient.GetAsync("products/ventas-generales").Result;
            var ventas = response.Content.ReadAsAsync<IEnumerable<VentasModel>>().Result;

            return ventas;
        }

        public IEnumerable<ProductModel> getVentasPorProducto()
        {
            ApiController.InitializeClient();

            HttpResponseMessage response = ApiController.ApiClient.GetAsync("products/ventas-por-producto").Result;
            var ventas = response.Content.ReadAsAsync<IEnumerable<ProductModel>>().Result;

            return ventas;
        }

        public IEnumerable<VentasModel> getVentasPorMes()
        {
            ApiController.InitializeClient();

            HttpResponseMessage response = ApiController.ApiClient.GetAsync("products/ventas-por-mes").Result;
            var ventas = response.Content.ReadAsAsync<IEnumerable<VentasModel>>().Result;

            return ventas;
        }

        public IEnumerable<ProductModel> getVentasPorProductoMes()
        {
            ApiController.InitializeClient();

            HttpResponseMessage response = ApiController.ApiClient.GetAsync("products/ventas-por-producto-mes").Result;
            var ventas = response.Content.ReadAsAsync<IEnumerable<ProductModel>>().Result;

            return ventas;
        }

        public IEnumerable<ProductModel> getTopNumeroVentas()
        {
            ApiController.InitializeClient();

            HttpResponseMessage response = ApiController.ApiClient.GetAsync("products/top-numero-ventas").Result;
            var ventas = response.Content.ReadAsAsync<IEnumerable<ProductModel>>().Result;

            return ventas;
        }

        public IEnumerable<ProductModel> getTopVentas()
        {
            ApiController.InitializeClient();

            HttpResponseMessage response = ApiController.ApiClient.GetAsync("products/top-ventas").Result;
            var ventas = response.Content.ReadAsAsync<IEnumerable<ProductModel>>().Result;

            return ventas;
        }

        public IEnumerable<ProductModel> getStock()
        {
            ApiController.InitializeClient();

            HttpResponseMessage response = ApiController.ApiClient.GetAsync("products/stock").Result;
            var stock = response.Content.ReadAsAsync<IEnumerable<ProductModel>>().Result;

            return stock;
        }
    }
}
