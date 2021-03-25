using System;
using System.Web.UI;
using System.Net.Http;
using Newtonsoft.Json;
using Utilitarios;
using System.Web;
using System.Net.Http.Headers;


public partial class View_domiciliario_configurarDomici : System.Web.UI.Page
{
    UEncapUsuario user = new UEncapUsuario();
    protected void Page_Load(object sender, EventArgs e)
    {
        user = JsonConvert.DeserializeObject<UEncapUsuario>(Request.Cookies["cookie"].Value);
        LB_nombre.Text = user.Nombre;
        LB_apellido.Text = user.Apellido;
        LB_correo.Text = user.Correo;
        LB_contraseña.Text = user.Clave;
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected async void BTN_editarCorreo_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UEncapUsuario usuario = new UEncapUsuario();
        usuario.Correo = TB_editCorreo.Text;
        string url = "http://18.224.240.8/api/Domiciliario/editarcorreo";
        var HttpClient = new HttpClient();
        UEncapUsuario user = JsonConvert.DeserializeObject<UEncapUsuario>(Request.Cookies["cookie"].Value);
        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);
        var body = JsonConvert.SerializeObject(usuario);
        HttpContent content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        var httpResponse = await HttpClient.PutAsync(url, content);
        string res = httpResponse.Content.ReadAsStringAsync().Result;
        if (httpResponse.Content.ReadAsStringAsync().Result.Equals("\"el correo ya se encuentra asociado a una cuenta\""))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ( 'el correo ya se encuentra asociado a una cuenta' );</script>");
        }else if (httpResponse.Content.ReadAsStringAsync().Result.Equals("\"debe ingresar el correo a cambiar\""))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ( 'debe ingresar el correo a cambiar' );</script>");
        }
        else if (httpResponse.Content.ReadAsStringAsync().Result.Equals("\"el correo se ha modificado satisfactoriamente\""))
        {
            user.Correo = TB_editCorreo.Text;
            LB_correo.Text = user.Correo;
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ( 'el correo se ha modificado satisfactoriamente' );</script>");
            TB_editCorreo.Text = "";
        }
    }

    protected void BTN_cancelar_Click(object sender, EventArgs e)
    {

    }

    protected async void BTN_editarPass_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UEncapUsuario usuario = new UEncapUsuario();
        usuario.Clave = TB_editarPass.Text;
        string url = "http://18.224.240.8/api/Domiciliario/modificarclave";
        var HttpClient = new HttpClient();
        UEncapUsuario user = JsonConvert.DeserializeObject<UEncapUsuario>(Request.Cookies["cookie"].Value);
        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);
        var body = JsonConvert.SerializeObject(usuario);
        HttpContent content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        var httpResponse = await HttpClient.PutAsync(url, content);
        string res = httpResponse.Content.ReadAsStringAsync().Result;
        if (httpResponse.Content.ReadAsStringAsync().Result.Equals("\"el correo ya se encuentra asociado a una cuenta\""))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ( 'el correo ya se encuentra asociado a una cuenta' );</script>");
        }
        else if (httpResponse.Content.ReadAsStringAsync().Result.Equals("\"debe ingresar el correo a cambiar\""))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ( 'debe ingresar el correo a cambiar' );</script>");
        }
        else if (httpResponse.Content.ReadAsStringAsync().Result.Equals("\"el correo se ha modificado satisfactoriamente\""))
        {
            user.Correo = TB_editCorreo.Text;
            LB_correo.Text = user.Correo;
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ( 'el correo se ha modificado satisfactoriamente' );</script>");
            TB_editCorreo.Text = "";
        }
    }

    protected void BTN_cancelar2_Click(object sender, EventArgs e)
    {

    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }

}