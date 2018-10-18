using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Net.Mail;

public partial class _Default : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
            lbl_entertime.Text = Session["entertime"].ToString();
            Label2.Text = DateTime.Now.ToString();

            if (Session["startTime"] == null)
            {
                Session["startTime"] = DateTime.Now;
            }
            else
            {
                DateTime a = (DateTime)Session["startTime"];
                DateTime b = DateTime.Now;
                TimeSpan c = b.Subtract(a);
                Label1.Text = c.ToString();
                //کمک میکند که مقایسه انجام شود

                if (c > TimeSpan.Parse(ConfigurationManager.AppSettings["time"]))
                {
                    btn_save.Visible = false;
                }
            }

            lbl_entertime.Text = Session["startTime"].ToString();
    }
    protected void btn_save_Click(object sender, EventArgs e)
    {
        string fileExtPhoto = "";
        string fileExtAllowForPhoto = "";
        long fileSizePhoto = 0;
        int fileSizeMaxForPhoto = 0;
        int indexFound = 0;
        bool uploadPhotoSuccess = false;

        if (fuPhoto.FileName.Length != 0)
        {
             fileExtPhoto = Path.GetExtension(fuPhoto.FileName);
             fileExtAllowForPhoto = ConfigurationManager.AppSettings["PHOTO_TYPE_ALLOW"];
             fileSizePhoto = fuPhoto.FileContent.Length;
             fileSizeMaxForPhoto = Convert.ToInt32(ConfigurationManager.AppSettings["PHOTO_MAX_LENGTH"]);
             indexFound = fileExtAllowForPhoto.IndexOf(fileExtPhoto);

            if (indexFound >= 0)
            {
                if (fileSizePhoto <= fileSizeMaxForPhoto)
                {
                    try
                    {
                        //اجرای عملیات آپلود

                        fuPhoto.SaveAs(Server.MapPath(ConfigurationManager.AppSettings["PHOTO_UPLOAD_PATH"]) + txt_codemeli.Text + fileExtPhoto);
                        uploadPhotoSuccess = true;
                    }
                    catch (Exception)
                    {
                        lblMessage.Text = "Sorry, There was a problem on saving photo to server!";
                    }
                }
                else
                {
                    lblMessage.Text = "Upload status: File not uploaded, Please choose corect size!";
                }
            }
            else
            {
                //نمایش پیغام به کاربر
                lblMessage.Text = "Upload status: File not uploaded, Please choose corect format!";
            }
        }
        else
        {
            lblMessage.Text = "Upload status: you should select photo to upload !";
        }

        if (uploadPhotoSuccess == true)
        {

            //StreamWriter sw = new StreamWriter(Server.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]), true);
            //sw.WriteLine(txt_name.Text + "," + txt_lastname.Text + "," + txt_codemeli.Text + "," + txt_father.Text + "," + txt_address.Text + "," + txt_tell.Text + "," + txt_mail.Text + "," + year.Text + "/" + month.Text + "/" + day.Text + "," + reshte.SelectedValue + "," + madrak.SelectedValue + "," + fileExtPhoto);
            //sw.Close();
            //استفاده از مبحث کلاس ها
            UserInfoItem objUserInfo = new UserInfoItem();
            objUserInfo.FirstName = txt_name.Text;
            objUserInfo.LastName = txt_lastname.Text;
            objUserInfo.FatherName = txt_father.Text;
            objUserInfo.NCode = txt_codemeli.Text;
            objUserInfo.Tell = txt_tell.Text;
            objUserInfo.Email = txt_mail.Text;
            objUserInfo.Major = reshte.SelectedValue;
            objUserInfo.Education = madrak.SelectedValue;
            objUserInfo.Gender = rblGender.SelectedValue;
            objUserInfo.Birthday = year.Text + "/" + month.Text + "/" + day.Text;
            objUserInfo.Address = txt_address.Text;
            objUserInfo.Extention = fileExtPhoto;
            UserInfoLogic l = new UserInfoLogic();
            l.Insert(objUserInfo);
        
            //در آخرین خط کد یعنی خط بالا ،متد اینزرت  را در کلاس یوزر اینفو صدا زدیم و چون فاقد ورودی است داخل پرانتزش خالی است.
        }

        StreamReader n = new StreamReader(Server.MapPath("~/emailpage.html"));
        string m = "";
        while (n.Peek() > 0)
        {
            m = m + n.ReadLine();
        }

        m = m.Replace("{name}", txt_name.Text);
        m = m.Replace("{lastname}", txt_lastname.Text);
        m = m.Replace("{codemeli}", txt_codemeli.Text);
        string tvl = day.Text + "/" + month.Text + "/" + year.Text;
        m = m.Replace("{tavalod}", tvl);
        m = m.Replace("{email}", txt_mail.Text);
        m = m.Replace("{reshte}", reshte.Text);
        m = m.Replace("{madrak}", madrak.Text);

        MailMessage mail = new MailMessage();
        mail.To.Add(txt_mail.Text);
        //mail.To.Add(txtmail.Text);
        mail.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["SENDER_ID"]);
        mail.Subject = "اطلاعات فردی";
        mail.SubjectEncoding = System.Text.Encoding.UTF8;
        mail.Body = m;
        mail.BodyEncoding = System.Text.Encoding.UTF8;
        mail.IsBodyHtml = true;
        mail.Priority = MailPriority.High;

        SmtpClient aryavandidadsmtpc = new SmtpClient();

        try
        {
            aryavandidadsmtpc.Send(mail);
            lblshow.Text = "Successfully Send...";
        }
        catch (Exception ex)
        {
            lblshow.Text = "Sending Failed...";
        }

    }

}