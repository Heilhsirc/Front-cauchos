using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;
using Utilitarios;


public partial class View_administrador_configuraradmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    protected async void BTN_editarCorreo_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UEncapUsuario usuario = new UEncapUsuario();
        usuario.Nombre = LB_nombre.Text;
        usuario.Apellido = LB_apellido.Text;
        usuario.Correo = LB_correo.Text;
        string url = "http://localhost:55147/api/admin/modificarCorreo";
        var HttpClient = new HttpClient();
        var body = JsonConvert.SerializeObject(usuario);
        HttpContent content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        var httpResponse = await HttpClient.PostAsync(url, content);
        if (httpResponse.IsSuccessStatusCode)
        {
            var mensaje = await httpResponse.Content.ReadAsStringAsync();
        }
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ( 'El correo ya se encuentra registrado' );</script>");
    }

    protected void BTN_cancelar_Click(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        
    }

    protected void BTN_editarPass_Click(object sender, EventArgs e)
    {
       
    }

    protected void BTN_cancelar2_Click(object sender, EventArgs e)
    {

    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }
}