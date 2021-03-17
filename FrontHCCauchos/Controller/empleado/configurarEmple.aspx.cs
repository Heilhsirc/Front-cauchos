using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class View_empleado_configurarEmple : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void BTN_editarCorreo_Click(object sender, EventArgs e)
    {


    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void BTN_cancelar_Click(object sender, EventArgs e)
    {

    }

    protected void BTN_editarPass_Click(object sender, EventArgs e)
    {
        //actualizar datos de usuario 

    }

    protected void BTN_cancelar2_Click(object sender, EventArgs e)
    {

    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void B_cerrar_mensaje1_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        PanelMensaje2.Visible = false;
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
}