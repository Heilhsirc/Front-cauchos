using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_administrador_Admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {



    }

    protected void BTN_cerrar_Sesion_Click(object sender, EventArgs e)
    {
        /*UEncapUsuario usuario = new UEncapUsuario();
        usuario = new LLogin().usuarioActivo2((string)Session["correo"]);
        usuario.Ip_ = null;
        usuario.Mac_ = null;
        usuario.Sesion = null;
        new LLogin().actualizarUsuario(usuario);*/
        Session["correo"] = null;
        Session["valido"] = -1;
        Session.Abandon();
        Session.RemoveAll();
        Response.Redirect("../home.aspx");


    }
}
