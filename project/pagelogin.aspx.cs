using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;

public partial class pagelogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEnter_Click(object sender, EventArgs e)
    {

        if (username.Text == "admin" && password.Text == "admin")
        {
            Session["loggedin"] = true;
            Session["IsAdmin"] = true;
            Response.Redirect("Default.aspx");
        }
        else
        {
            string j = username.Text;
            string k = password.Text;
            UserInfoLogic objUserInfo = new UserInfoLogic();
            UserInfoItem n = objUserInfo.GetUserInfoByEmailAndNCode(j, k);

            //if (n.IsFill == true)
            if(string.IsNullOrEmpty(n.FirstName) == false)
            {
                Session["loggedin"] = true;
                Session["IsAdmin"] = false;
                Session["nam"] = n.FirstName;
                Session["lastnam"] = n.LastName;
                Session["imagecode"] = n.NCode;
                Session["pasvandpic"] = n.Extention;
                Response.Redirect("Default.aspx");
            }
            else
            {
                //نام کاربری یا کلمه عبور صحیح نیست
                //لطفا دوباره تلاش کنید
            }
            //    StreamReader sr = new StreamReader(Server.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
            //    while (!sr.EndOfStream)
            //    {
            //        string i = sr.ReadLine();
            //        if (i.IndexOf(username.Text) >= 0 && i.IndexOf(password.Text)>=0)
            //        {
            //            Session["loggedin"] = true;
            //            Session["IsAdmin"] = false;
            //            string[] splitetext = i.Split(',');
            //            Session["nam"] = splitetext[0];
            //            Session["lastnam"] = splitetext[1];
            //            Session["imagecode"] = splitetext[3];
            //            Session["pasvandpic"] = splitetext[11];
            //            Response.Redirect("Default.aspx");


            //        }
            //        else
            //        {
            //            Session["loggedin"] = false;
            //            lbl_show.Text = "enter correct username and password";
            //        }
            //    }
            //    sr.Close();

        }

    }
}