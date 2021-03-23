using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web.UI;
using Utilitarios;


public partial class View_Recuperacion_clave : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected async void BTN_Recuperar_Click(object sender, EventArgs e) {
        UEncapUsuario user = new UEncapUsuario();
        user.Correo= TB_CorreoRecuperar.Text;
        string url = "http://18.224.240.8/api/Recuperar_Contraseña/Recuperar_Clave";
        var HttpClient = new HttpClient();
        var body = JsonConvert.SerializeObject(user);
        HttpContent content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        var httpResponse = await HttpClient.PostAsync(url, content);
        string res = httpResponse.Content.ReadAsStringAsync().Result;
        if (res != null)
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>var men = '<%=res%>'; alert(res);window.location=\" ../login.aspx\"</script>");
        }
    }

    protected void BTN_inicio_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/home.aspx");
    }
}