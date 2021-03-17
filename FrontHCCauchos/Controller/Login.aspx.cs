using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;
using utilitarios;

public partial class View_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //CREAR LA VALIDACION DE CORREO //

    }

    protected async void BTN_ingresar_Click(object sender, EventArgs e)
    {
        string url = "http://localhost:55147/api/values/";
        var HttpClient = new HttpClient();
        var json = await HttpClient.GetStringAsync(url);
        //HttpClient.Method = "get";
        //request.ContentType = "application/json;charset=UTF-8";
        var lista = JsonConvert.DeserializeObject(json);
        Console.Write(lista);

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