
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Utilitarios;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

public partial class View_administrador_HistorialPedido : System.Web.UI.Page
{
    protected async void Page_Load(object sender, EventArgs e)
    {
        UEncapUsuario user = JsonConvert.DeserializeObject<UEncapUsuario>(Request.Cookies["cookie"].Value);
        string url = "http://localhost:55147/api/Admin/ConsultarPedidos";
        var HttpClient = new HttpClient();
        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);
        var json = await HttpClient.GetStringAsync(url);
        List<UEncapPedido> lista = JsonConvert.DeserializeObject<List<UEncapPedido>>(json);
        GV_Pedidos.DataSource = lista;
        GV_Pedidos.DataBind();
    }

    protected void GV_Pedidos_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Btn_todos_Click(object sender, EventArgs e)
    {
    }

    protected void DDL_Estado_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    

    protected void GV_Pedidos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
    }
}