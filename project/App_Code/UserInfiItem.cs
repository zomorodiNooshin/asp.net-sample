using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Configuration;
using System.Web.Hosting;

/// <summary>
/// Summary description for Class2
/// </summary>
public class UserInfoItem
{
    #region properties

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FatherName { get; set; }
    public string NCode { get; set; }
    public string Address { get; set; }
    public string Tell { get; set; }
    public string Email { get; set; }
    public string Major { get; set; }
    public string Education { get; set; }
    public string Birthday { get; set; }
    public string Gender { get; set; }
    public string Extention { get; set; }
    public string imagecode { get; set; }
    public bool IsFill { get; set; }

    #endregion


    //public UserInfo()
    //{


    //}

    //public int Insert()
    //{
    //    int retval = 0;
    //    if (FirstName == "" || LastName == "" || FatherName == "" || NCode == "" || Address == "" || Tell == "" || Email == "" || Major == "" || Education == "" || Birthday == "" || Gender == "")
    //    {
    //        retval = -1;
    //    }
    //    if (retval == 0)
    //    {
    //        try
    //        {
    //            StreamWriter sw = new StreamWriter(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]),true);
    //            sw.WriteLine(this.FirstName + "," + LastName + "," + FatherName + "," + NCode + "," + Address + "," + Tell 
    //                + "," + Email + "," + Major + "," + Education + "," + Birthday + "," + Gender+","+this.Extention);
    //            sw.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            retval = -2;
    //        }
    //    }
    //    return retval;
    //}
    //public bool CheckExistNCode(string nationalCode)
    //{

    //    bool existed = false;
    //    StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
    //    while (!sr.EndOfStream)
    //    {
    //        string i = sr.ReadLine();
    //        string[] splitetext = i.Split(',');
    //        if (nationalCode == splitetext[3])
    //        {
    //            existed = true;
    //            break;
    //        }
    //    }
    //    sr.Close();
    //    return existed;
    //}
    //public bool logInByNCodeAndEmail(string emailaddress,string nationalCode)
    //{
    //    bool loggedIn = false;
    //    StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
    //    while (!sr.EndOfStream)
    //    {
    //        string i = sr.ReadLine();
    //        string[] splitetext = i.Split(',');
    //        if (nationalCode == splitetext[3]&& emailaddress == splitetext[6])
    //        {
    //            loggedIn = true;
    //            break;
    //        }
    //    }

    //    sr.Close();
    //    return loggedIn;
    //}
    //public bool GetUserInfoByNCode(string nationalCode)
    //{
    //    bool existed = false;
    //    StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
    //    while (!sr.EndOfStream)
    //    {
    //        string i = sr.ReadLine();
    //        string[] splitetext = i.Split(',');
    //        if (nationalCode == splitetext[3])
    //        {
    //            this.FirstName = splitetext[0];
    //            this.LastName = splitetext[1];
    //            this.FatherName = splitetext[2];
    //            this.NCode = splitetext[3];
    //            this.Address = splitetext[4];
    //            this.Tell = splitetext[5];
    //            this.Email = splitetext[6];
    //            this.Major = splitetext[7];
    //            this.Education = splitetext[8];
    //            this.Birthday = splitetext[9];
    //            this.Gender = splitetext[10];
    //            this.Extention = splitetext[11];

    //            existed = true;
    //            break;
    //        }
    //    }
    //    sr.Close();
    //    return existed;
    //}
    //public bool GetUserInfoByEmailAndNCode(string emailaddress, string nationalCode)
    //{
    //    bool existed = false;
    //    StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
    //    while (!sr.EndOfStream)
    //    {
    //        string i = sr.ReadLine();
    //        string[] splitetext = i.Split(',');
    //        if (nationalCode == splitetext[3]&& emailaddress==splitetext[6])
    //        {
    //            this.FirstName = splitetext[0];
    //            this.LastName = splitetext[1];
    //            this.FatherName = splitetext[2];
    //            this.NCode = splitetext[3];
    //            this.Address = splitetext[4];
    //            this.Tell = splitetext[5];
    //            this.Email = splitetext[6];
    //            this.Major = splitetext[7];
    //            this.Education = splitetext[8];
    //            this.Birthday = splitetext[9];
    //            this.Gender = splitetext[10];
    //            this.Extention = splitetext[11];

    //            existed = true;
    //            break;
    //        }
    //    }
    //    sr.Close();
    //    return existed;
    //}




}