using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

public partial class View_administrador_AgregarInventario : System.Web.UI.Page
{
    UEncapUsuario user = new UEncapUsuario();
    protected void Page_Load(object sender, EventArgs e)
    {
        user = JsonConvert.DeserializeObject<UEncapUsuario>(Request.Cookies["cookie"].Value);

    }

    protected async void BTN_subir_Click(object sender, EventArgs e)
    {
        UEncapInventario item = new UEncapInventario();
        item.Referencia = TB_referencia.Text;
        item.Referencia = TB_Precio.Text;
        item.Titulo = TB_Titulo.Text;
        item.Ca_minima = Int32.Parse(TB_Minima.Text);
        UEncapUsuario user = JsonConvert.DeserializeObject<UEncapUsuario>(Request.Cookies["cookie"].Value);
        string url = "http://18.224.240.8/api/Admin/InsertarItem";
        var HttpClient = new HttpClient();
        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);
        var body = JsonConvert.SerializeObject(item);
        HttpContent content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        var json = await HttpClient.PostAsync(url, content);
        string res = await json.Content.ReadAsStringAsync();

    }

    protected void B_cerrar_mensaje1_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
    }
}