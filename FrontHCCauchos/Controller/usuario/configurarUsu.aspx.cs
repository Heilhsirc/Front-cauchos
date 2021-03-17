using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class View_usuario_configurarUsu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) { }

    protected void BTN_editarCorreo_Click(object sender, EventArgs e) { }

    protected void BTN_cancelar_Click(object sender, EventArgs e) { }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //desoculto elementos para poder editar
        TB_editCorreo.Visible = true;
        BTN_editarCorreo.Visible = true;
        BTN_cancelar.Visible = true;
    }

    protected void BTN_editarPass_Click(object sender, EventArgs e) { }

    protected void BTN_cancelar2_Click(object sender, EventArgs e)
    {
        TB_editarPass.Visible = false;
        BTN_editarPass.Visible = false;
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        TB_editarPass.Visible = true;
        BTN_editarPass.Visible = true;
        BTN_cancelar2.Visible = true;
    }
}