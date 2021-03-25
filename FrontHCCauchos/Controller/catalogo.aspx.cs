using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Utilitarios;

public partial class View_catalogo : System.Web.UI.Page
{
    protected async void Page_Load(object sender, EventArgs e)
    {
        string url = "http://18.224.240.8/api/usuario/catalogo";
        var HttpClient = new HttpClient();
        var json = await HttpClient.GetStringAsync(url);
        List<UEncapInventario> lista = JsonConvert.DeserializeObject<List<UEncapInventario>>(json);
        Repeater1.DataSource = lista;
        Repeater1.DataBind();
    }
}