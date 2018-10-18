using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PersonalList2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UserInfoLogic usersList = new UserInfoLogic();
        List<UserInfoItem> AllUsers = new List<UserInfoItem>();
        AllUsers = usersList.GetAllData();
        LV1.DataSource = AllUsers;
        LV1.DataBind();
        LV2.DataSource = AllUsers;
        LV2.DataBind();
        DV1.DataSource = AllUsers;
        DV1.DataBind();
    }
}