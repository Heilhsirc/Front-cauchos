using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Utilitarios;
using System.Web.UI.WebControls;


public partial class View_domiciliario_entregas : System.Web.UI.Page
{
    UEncapUsuario user = new UEncapUsuario();
    protected async void Page_Load(object sender, EventArgs e)
    {
        try
        {
            user = JsonConvert.DeserializeObject<UEncapUsuario>(Request.Cookies["cookie"].Value);
            string url = "http://18.224.240.8/api/Domiciliario/obtenerpedidos";
            var HttpClient = new HttpClient();
            var json = await HttpClient.GetStringAsync(url);
            List<UEncapPedido> lista = JsonConvert.DeserializeObject<List<UEncapPedido>>(json);
            if (lista.Count != 0)
            {
                R_pedido.DataSource = lista;
                R_pedido.DataBind();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void R_pedido_ItemCommand(object source, RepeaterCommandEventArgs e)
    {


    }
}