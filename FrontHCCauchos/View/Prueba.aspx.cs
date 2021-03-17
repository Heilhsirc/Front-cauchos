using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;
using Utilitarios;

public partial class View_Prueba : System.Web.UI.Page
{
    List<UEncapInventario> list = new List<UEncapInventario>();
    protected async void Page_Load(object sender, EventArgs e)
    {
        string url = "http://localhost:55147/api/usuario/catalogo";
        var HttpClient = new HttpClient();
        var json = await HttpClient.GetStringAsync(url);
        list = JsonConvert.DeserializeObject<List<UEncapInventario>>(json);
        Repeater1.DataSource = list;
        Repeater1.DataBind();
    }

    protected  void Button1_Click(object sender, EventArgs e)
    {
       
    }
}