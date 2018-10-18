using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;


public partial class personview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)

    {
        //if (Session["loggedin"] == null)
        //{
        //    Response.Redirect("pagelogin.aspx");
        //}
        //else
        //{

        string searchm = Request.QueryString["meli"];
        if (string.IsNullOrEmpty(searchm))
        {
            Response.Redirect("~/searchpage.aspx");
        }
        else
        {
            //StreamReader sr = new StreamReader(Server.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
            //while (!sr.EndOfStream)
            //{
            //    string i = sr.ReadLine();
            //    if (i.IndexOf(searchm) >= 0)
            //    {
            //        string[] splitetext = i.Split(',');
            //        txt_name2.Text = splitetext[0];
            //        txt_lastname2.Text = splitetext[1];
            //        txt_codemeli2.Text = splitetext[2];
            //        txt_father.Text = splitetext[3];
            //        tex_mail2.Text = splitetext[4];
            //        txt_reshte2.Text = splitetext[5];
            //        txt_madrak2.Text = splitetext[6];
            //        imageperson.ImageUrl = ConfigurationManager.AppSettings["PHOTO_UPLOAD_PATH"] + searchm + ".jpg";
            //    }
            //}
            //sr.Close();
            //بجای استفاده از کد های بالا ،حالا می خواهیم از کلاس استفاده نماییم
            UserInfoLogic objUserInfo = new UserInfoLogic();

            UserInfoItem z = objUserInfo.GetUserInfoByNCode(searchm);
            if (z.IsFill == true)
            {
                txt_name2.Text = z.FirstName;
                txt_lastname2.Text = z.LastName;
                txt_codemeli2.Text = z.NCode;
                txt_father.Text = z.FatherName;
                tex_mail2.Text = z.Email;
                txt_reshte2.Text = z.Major;
                txt_madrak2.Text = z.Education;
                imageperson.ImageUrl = ConfigurationManager.AppSettings["PHOTO_UPLOAD_PATH"] + z.NCode + z.Extention;

            }
        }

        //}

    }
    //وارد کردن متد سرچ کد ملی

}