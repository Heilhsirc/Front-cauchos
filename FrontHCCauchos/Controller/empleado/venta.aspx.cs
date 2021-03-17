using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class View_empleado_venta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void BTN_BuscarClien_Click(object sender, EventArgs e)
    {
        GV_Clientes.DataSourceID = "ODS_ClientesCedu";
    }

    protected void BTN_buscarTodos_Click(object sender, EventArgs e)
    {
        GV_Clientes.DataSourceID = "ODS_Clientes";
    }

    protected void BTN_RegistrarCliente_Click(object sender, EventArgs e)
    {
        Response.Redirect("registrarCliente.aspx");
    }

    protected void BTN_Facturar_Click(object sender, ImageClickEventArgs e)
    {
        
    }

    protected void GV_Clientes_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {

    }



    protected void LinkButton2_Click(object sender, EventArgs e)
    {

        PanelMensaje2.Visible = false;
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        PanelMensaje1.Visible = false;
    }

    protected void B_cerrar_mensaje1_Click(object sender, EventArgs e)
    {

        PanelMensaje.Visible = false;
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