using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Net.Mail;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        lblTedadonline.Text = Application["TotalOnlineUsers"].ToString();
        //lbl_entertime.Text = Session["entertime"].ToString();
        lblNowtime.Text = DateTime.Now.ToString();
       //زمان ورود باید ثابت بماند
        // در صورت چک نکردن خالی بودن یا نبودن هی دیت تایم دات نا را میریزه تو سشن و نمایش می دهد بنابراین ثابت نمی ماند  
        if (Session["startTime"] == null)
        {
            Session["startTime"] = DateTime.Now;
        }
        else
        {
            DateTime a = (DateTime)Session["startTime"];
            DateTime b = DateTime.Now;
            TimeSpan c = b.Subtract(a);
            lblPasstime.Text = c.ToString();






            if (c > TimeSpan.Parse(ConfigurationManager.AppSettings["time"]))
            {
                lblVaziat.Text = "your time is expired";
            }
        }

        lblVorodtime.Text = Session["startTime"].ToString();
        UserInfoLogic d = new UserInfoLogic();
        int x = d.NumberOfRejisterd();
        lblSabtenamiha.Text=x.ToString();
        

        //StreamReader sabtenamiha = new StreamReader(Server.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
        //int k = 0;
        //while (sabtenamiha.Peek() > 0)
        //{

        //    sabtenamiha.ReadLine();
        //    k++;

        //}
        //lblSabtenamiha.Text= k.ToString();
    }


}