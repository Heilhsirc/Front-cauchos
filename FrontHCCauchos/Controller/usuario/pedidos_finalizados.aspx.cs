using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_usuario_pedidos_finalizados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        var btn_factura = e.Item.FindControl("Btn_factura") as Button;
        var lb_idfac = e.Item.FindControl("Id") as Label;
        Session["Id_fac"] = Convert.ToInt32(lb_idfac.Text);
        //Response.Redirect("Factura.aspx");
    }
}