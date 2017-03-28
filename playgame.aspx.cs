using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class playgame : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void backid_Click(object sender, EventArgs e)
    {
        Response.Redirect("mainmenu.aspx");
    }
    protected void level5id_Click(object sender, EventArgs e)
    {

    }
    protected void level1id_Click(object sender, EventArgs e)
    {
        Response.Redirect("level1.aspx");
    }
}