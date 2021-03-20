using System;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using Utilitarios;
public partial class View_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.Cookies["cookie"] != null)
        {
            UEncapUsuario user = JsonConvert.DeserializeObject<UEncapUsuario>(Request.Cookies["cookie"].Value);
            Redirect(user);
        }
        
    }

    protected async void BTN_ingresar_Click(object sender, EventArgs e)
    {
        LoginRequest usuario = new LoginRequest();
        usuario.correo = TB_correo.Text;
        usuario.clave = TB_contraseña.Text;
        usuario.AplicacionId = 1;
        string url = "http://localhost:55147/api/login/login";
        var HttpClient = new HttpClient();
        var body = JsonConvert.SerializeObject(usuario);
        HttpContent content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        HttpResponseMessage httpResponse = await HttpClient.PostAsync(url, content);
        UEncapUsuario user = JsonConvert.DeserializeObject<UEncapUsuario>(httpResponse.Content.ReadAsStringAsync().Result);
        if (user != null)
        {
            HttpCookie cookie = new HttpCookie("cookie");
            cookie.Value = httpResponse.Content.ReadAsStringAsync().Result;
            cookie.Expires = DateTime.Now.AddMinutes(30);
            Response.Cookies.Add(cookie);
            Redirect(user);
        }
    }

    protected void LButton_Recuperar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Recuperacion_clave.aspx");
    }

    protected void BTN_si_Click(object sender, EventArgs e)
    {
        //UEncapUsuario userb = new UEncapUsuario();
        //userb.Correo = TB_correo.Text;
        BTN_si.Visible = false;
        BTN_no.Visible = false;
       // string mensaje = new LLogin().Actualizar(userb);
        //MostrarMensaje(mensaje);
    }
    protected void BTN_no_Click(object sender, EventArgs e)
    {
        BTN_si.Visible = false;
        BTN_no.Visible = false;
    }

    private void Redirect(UEncapUsuario user)
    {
        switch (user.Rol_id)
        {
            case 1:
                Response.Redirect("administrador/configuraradmin.aspx");
                break;
            case 2:
                Response.Redirect("empleado/index_empleado.aspx");
                break;
            case 3:
                Response.Redirect("domiciliario/index_domiciliario.aspx");
                break;
            case 4:
                Response.Redirect("usuario/index_usuario.aspx");
                break;
        }
        if (user.Rol_id == 2)
        {
            MostrarMensaje1($"Su cuenta se encuentra en estado de recuperacion");
            return;
        }
        else if (user.Rol_id == 3)
        {
            MostrarMensaje($"Su cuenta ha sido inhabilitada, comuniquese con el con el administrador");
            return;
        }
    }

    private void MostrarMensaje(string mensaje)
    {
        LblMensaje.Text = mensaje;
        PanelMensaje.Visible = true;
    }

    private void MostrarMensaje1(string mensaje)
    {
        LblMensaje1.Text = mensaje;
        PanelMensaje1.Visible = true;
    }

}