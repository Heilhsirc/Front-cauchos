using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class View_usuario_eliminarcuenta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

       
    }

    protected void IB_eliminar_Click(object sender, ImageClickEventArgs e)
    {
        BTN_si.Visible = true;
        BTN_no.Visible = true;
        LB_Seguro.Visible = true;
    }

    protected void BTN_si_Click(object sender, EventArgs e)
    {
    }

    protected void BTN_no_Click(object sender, EventArgs e)
    {
        BTN_si.Visible = false;
        BTN_no.Visible = false;
        LB_Seguro.Visible = false;
    }
}