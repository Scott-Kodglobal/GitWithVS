using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string first = TextBox1.Text;
        string second = TextBox2.Text;
        Response.Write("<script>confirm('Hello "+first+" "+second+" ');</script>");
        TextBox1.Text = null;
        TextBox2.Text = null;
        //Response.Redirect();
    }
}