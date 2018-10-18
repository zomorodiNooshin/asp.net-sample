using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class linkGridviewAndFormview : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["loggedin"] == null)
        //{
        //    Response.Redirect("pagelogin.aspx");
        //}
        //else
        //{
        if (!Page.IsPostBack)
        {
            UserInfoLogic usersList = new UserInfoLogic();
            List<UserInfoItem> AllUsers = new List<UserInfoItem>();
            AllUsers = usersList.GetAllData();
            gvPerson2.DataSource = AllUsers;
            gvPerson2.DataBind();
            
        }
        


        //}
    }

    protected void gvPerson2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string x = gvPerson2.SelectedValue.ToString();
        UserInfoLogic usersList = new UserInfoLogic();
        List<UserInfoItem> AllUsers = new List<UserInfoItem>();
       UserInfoItem y= usersList.GetUserInfoByNCode(x);
        AllUsers.Add(y);
        FV2.DataSource = AllUsers;
        FV2.DataBind();

    }
}