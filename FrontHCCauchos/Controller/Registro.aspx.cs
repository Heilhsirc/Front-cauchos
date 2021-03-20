using System;
using System.Net.Http;
using System.Web.UI;
using Newtonsoft.Json;
using Utilitarios;



public partial class View_Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) { }

    protected async void BTN_registrar_Click(object sender, EventArgs e) {
        ClientScriptManager cm = this.ClientScript;
        UEncapUsuario usuario = new UEncapUsuario();
        usuario.Correo = TB_correo.Text;
        usuario.Nombre = TB_nombres.Text;
        usuario.Apellido = TB_apellidos.Text;
        usuario.Clave = TB_contraseña.Text;
        usuario.Fecha_nacimiento = DateTime.Parse(TB_fecha_nacimiento.Text);
        usuario.Identificacion = TB_identificacion.Text;
        string url = "http://localhost:55147/api/registro/";
        var HttpClient = new HttpClient();
        var body = JsonConvert.SerializeObject(usuario);
        HttpContent content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        var httpResponse = await HttpClient.PostAsync(url, content);
        string res = httpResponse.Content.ReadAsStringAsync().Result;
        if (res != null)
        {
            LblMensaje.Text = res;

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

    private void MostrarMensaje2(string mensaje)
    {
        LblMensaje2.Text = mensaje;
        PanelMensaje2.Visible = true;
    }

    protected void B_cerrar_mensaje1_Click(object sender, EventArgs e)
    {
        PanelMensaje.Visible = false;
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        PanelMensaje1.Visible = false;
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        PanelMensaje2.Visible = false;
    }
}