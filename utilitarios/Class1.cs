using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Utilitarios;

namespace utilitarios
{
    public class Class1
    {
        public async Task<List<UEncapInventario>> ObtenerCatalogo()
        {
            string url = "http://localhost:55147/api/usuario/catalogo";
            var HttpClient = new HttpClient();
            var json = await HttpClient.GetStringAsync(url);
            //HttpClient.Method = "get";
            //request.ContentType = "application/json;charset=UTF-8";
            List<UEncapInventario> lista = JsonConvert.DeserializeObject<List<UEncapInventario>>(json);
            return lista;
        }
    }
}
