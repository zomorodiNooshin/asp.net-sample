using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClassOfBasePage
/// </summary>
public class BasePage:System.Web.UI.Page
{
    protected override void OnLoadComplete(EventArgs e)
    {
        if (Session["loggedin"] == null)
        {
            Response.Redirect("pagelogin.aspx");
        }
        base.OnLoadComplete(e);
    }
    
}