using desktop_application.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace desktop_application.Controllers
{
    class InicioSesionController
    {
        public bool validarSesion(UsuarioModel usuario)
        {
            ApiController.InitializeClient();

            var json = JsonConvert.SerializeObject(usuario);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = ApiController.ApiClient.PostAsync("inicio-sesion", data).Result;
            string result = response.Content.ReadAsStringAsync().Result;

            return Convert.ToBoolean(result);
        }

        public bool validarEmail(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool validarContrasenia(string contrasenia)
        {
            String expresion;
            expresion = "^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{8,}$";
            if (Regex.IsMatch(contrasenia, expresion))
            {
                if (Regex.Replace(contrasenia, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
