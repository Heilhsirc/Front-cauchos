using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;


public partial class View_Recuperacion_clave : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void BTN_Recuperar_Click(object sender, EventArgs e) { }

    protected void BTN_inicio_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }
}