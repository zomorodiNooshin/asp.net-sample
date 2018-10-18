using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PersonalList : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
            UserInfoLogic usersList = new UserInfoLogic();
            List<UserInfoItem> AllUsers = new List<UserInfoItem>();
            AllUsers = usersList.GetAllData();
            gvPerson.DataSource = AllUsers;
            FV1.DataSource = AllUsers;
            Rp1.DataSource = AllUsers;
            gvPerson.DataBind();
            FV1.DataBind();
            Rp1.DataBind();
        
    }
}