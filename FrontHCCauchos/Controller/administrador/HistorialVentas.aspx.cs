using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Net.Http;
using System.Web.UI.WebControls;
using Utilitarios;

public partial class View_administrador_HistorialVentas : System.Web.UI.Page
{   

    protected async void Page_Load(object sender, EventArgs e)
    {
        UEncapUsuario user = JsonConvert.DeserializeObject<UEncapUsuario>(Request.Cookies["cookie"].Value);
        string url = "http://localhost:55147/api/Admin/ConsultVentas";
        var HttpClient = new HttpClient();
        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);
        var json = await HttpClient.GetStringAsync(url);
        List<UEncapPedido> lista = JsonConvert.DeserializeObject<List<UEncapPedido>>(json);
        GV_Historial.DataSource = lista;
        GV_Historial.DataBind();
    }

    protected void Btn_Buscar_Click(object sender, EventArgs e)
    {
       
    }

    protected void Btn_Todos_Click(object sender, EventArgs e)
    {
    }

    protected void RBL_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DDL_Empleado_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void GV_Historial_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
}