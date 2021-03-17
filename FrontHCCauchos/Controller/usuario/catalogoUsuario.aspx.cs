using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_usuario_catalogoUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Btn_Todos_Click(object sender, EventArgs e)
    {

    }

    protected void Btn_Buscar_Click(object sender, EventArgs e) { }

    public void reiniciarFiltros()
    {
        //reinicio de filtros y repeater
        //DDL_Precio.SelectedIndex = 0;
        //DD_Marca.SelectedIndex = 0;
        //DD_Categoria.SelectedIndex = 0;
    }

    protected void B_cerrar_mensaje1_Click(object sender, EventArgs e)
    {
        PanelMensaje1.Visible = false;
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e) { }

    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        int stock = int.Parse(((Label)e.Item.FindControl("Ca_actualLabel")).Text);
        var cantidad = (TextBox)e.Item.FindControl("TB_cantidad");

        if (stock <= 0)
        {
            cantidad.Enabled = false;
        }
    }
}