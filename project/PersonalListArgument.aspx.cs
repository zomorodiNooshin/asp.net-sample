using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Net.Mail;

public partial class PersonalListArgument : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
            string s = ddlEducation.SelectedValue;

            if (string.IsNullOrEmpty(s))
            {
                UserInfoLogic usersList = new UserInfoLogic();
                List<UserInfoItem> AllUsers = new List<UserInfoItem>();
                AllUsers = usersList.GetAllData();
                LVArgument.DataSource = AllUsers;
                LVArgument.DataBind();
            }
            else
            {
                UserInfoLogic y = new UserInfoLogic();
                List<UserInfoItem> x = new List<UserInfoItem>();
                x = y.FilterByEducation(ddlEducation.SelectedValue);
                LVArgument.DataSource = x;
                LVArgument.DataBind();
            }
        
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            UserInfoLogic usersList2 = new UserInfoLogic();
            List<UserInfoItem> AllUsers2 = new List<UserInfoItem>();
            AllUsers2 = usersList2.FilterByNameLastnameEmail(txt_name.Text, txt_lastname.Text, TextBox1.Text);
            LVArgument.DataSource = AllUsers2;
            LVArgument.DataBind();
        }
        catch
        {
            lblshow.Text = "یافت نشد";
        }


    }
}