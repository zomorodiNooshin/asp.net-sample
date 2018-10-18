using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class search : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void searchcode_Click(object sender, EventArgs e)
    {
        
            Response.Redirect("personview.aspx?meli=" + entercode.Text);

        
    }
}