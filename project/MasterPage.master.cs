using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Net.Mail;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["loggedin"] != null)
        {
            //کاربر لاگین کرده است

            if ((bool)Session["IsAdmin"] == true)
            {
                //کاربرادمین می باشد
                hprRegister.Visible = true;
                hprSearch.Visible = true;
                hprStatistics.Visible = true;
                hprLogin.Visible = false;
                hprlogout.Visible = true;
                logonv.Visible = true;
                secondNav.Visible = false;
                NavImage.Visible = false;
                vavdivpic.Visible = false;
                hprRegisteredPerson.Visible = true;
                hprAdvancedSearch.Visible = true;
            }
            else
            {
                //کاربر ادمین نیست
                hprRegister.Visible = false;
                hprSearch.Visible = true;
                hprStatistics.Visible = true;
                hprLogin.Visible = false;
                hprlogout.Visible = true;
                secondNav.Visible = true;
                logonv.Visible = false;
                secondNav.Visible = true;
                NavImage.Visible = true;
                vavdivpic.Visible = true;
                hprRegisteredPerson.Visible = false;
                hprAdvancedSearch.Visible = false;

                lblNavName.Text = Session["nam"].ToString();
                lblVavLastName.Text = Session["lastnam"].ToString();
                NavImage.ImageUrl = ConfigurationManager.AppSettings["PHOTO_UPLOAD_PATH"]+Session["imagecode"].ToString() + Session["pasvandpic"].ToString();
            }
        }
        else
        {
            //کاربر موفق به لاگین کردن نشده است
            hprRegister.Visible = false;
            hprSearch.Visible = false;
            hprStatistics.Visible = false;
            hprLogin.Visible = true;
            hprlogout.Visible = false;
            secondNav.Visible = false;
            NavImage.Visible = false;
            vavdivpic.Visible = false;
            hprRegisteredPerson.Visible = false;
            hprAdvancedSearch.Visible = false;


        }


    }

    protected void hprlogout_Click(object sender, EventArgs e)
    {
        //Session["loggedin"] = null;
        //Session["startTime"] = null;
        //Session["IsAdmin"] = null;
        Session.Clear();
    }
}
