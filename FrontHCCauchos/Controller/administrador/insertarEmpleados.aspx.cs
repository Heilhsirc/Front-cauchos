using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;
using Utilitarios;


public partial class View_administrador_insertarEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected async void BTN_registrar_empleado_Click(object sender, EventArgs e)
    {
        UEncapUsuario usuario = new UEncapUsuario();
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
        var httpResponse  = await HttpClient.PostAsync(url, content);
        if (httpResponse.IsSuccessStatusCode)
        {
            var mensaje = await httpResponse.Content.ReadAsStringAsync();
            respuesta.Text = mensaje;
            respuesta.Visible = true;
        }
        
    }

}