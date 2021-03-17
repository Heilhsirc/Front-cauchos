using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;
using Utilitarios;

public partial class View_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //CREAR LA VALIDACION DE CORREO //

    }

    protected async void BTN_ingresar_Click(object sender, EventArgs e)
    {
        LoginRequest login = new LoginRequest();
        usuario.Nombre = TB_nombres.Text;
        usuario.Apellido = TB_apellidos.Text;
        usuario.Correo = TB_correo.Text;
        usuario.Clave = TB_contraseña.Text;
        usuario.Fecha_nacimiento = DateTime.Parse(TB_fecha_nacimiento.Text);
        usuario.Identificacion = TB_identificacion.Text;
        usuario.Rol_id = Int32.Parse(DDL_tipo_empleado.SelectedValue);
        string url = "http://localhost:55147/api/empleado/registroClient";
        var HttpClient = new HttpClient();
        var body = JsonConvert.SerializeObject(usuario);
        HttpContent content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        var httpResponse = await HttpClient.PostAsync(url, content);
        if (httpResponse.IsSuccessStatusCode)
        {
            var mensaje = await httpResponse.Content.ReadAsStringAsync();
            respuesta.Text = mensaje;
            respuesta.Visible = true;
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




}