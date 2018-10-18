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
public class UserInfoLogic
{
    //#region properties

    //public string FirstName { get; set; }
    //public string LastName { get; set; }
    //public string FatherName { get; set; }
    //public string NCode { get; set; }
    //public string Address { get; set; }
    //public string Tell { get; set; }
    //public string Email { get; set; }
    //public string Major { get; set; }
    //public string Education { get; set; }
    //public string Birthday { get; set; }
    //public string Gender { get; set; }
    //public string Extention { get; set; }

    //#endregion


    //public UserInfo()
    //{


    //}
    public List<UserInfoItem> FilterByEducation(string education)
    {
        List<UserInfoItem> LItemFilter = new List<UserInfoItem>();
        try
        {
            StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
            while (!sr.EndOfStream)
            {
                UserInfoItem oItem = new UserInfoItem();
                string i = sr.ReadLine();
                string[] splitetext = i.Split(',');
                if (education == splitetext[8])
                {
                    oItem.FirstName = splitetext[0];
                    oItem.LastName = splitetext[1];
                    oItem.FatherName = splitetext[2];
                    oItem.NCode = splitetext[3];
                    oItem.Address = splitetext[4];
                    oItem.Tell = splitetext[5];
                    oItem.Email = splitetext[6];
                    oItem.Major = splitetext[7];
                    oItem.Education = splitetext[8];
                    oItem.Birthday = splitetext[9];
                    oItem.Gender = splitetext[10];
                    oItem.Extention = splitetext[11];

                    LItemFilter.Add(oItem);
                }
                
            }
            sr.Close();
        }
        catch
        {

        }
        return LItemFilter;


    }
    public List<UserInfoItem> FilterByNameLastnameEmail(string name,string lastname,string email)
    {
        List<UserInfoItem> LItemFilter = new List<UserInfoItem>();
        bool nameIsFound = false;
        bool lastnameIsFound = false;
        bool emailIsFound = false;
        bool isFound = false;

        try
        {
            StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
            while (!sr.EndOfStream)
            {
                UserInfoItem oItem = new UserInfoItem();
                string i = sr.ReadLine();
                string[] splitetext = i.Split(',');

                //if ((name == splitetext[0]&&(lastname==splitetext[1]||lastname==""))||(lastname == splitetext[1] && name == "") ||((email== splitetext[6]|| email == "") && (lastname == splitetext[1] || lastname == "")&& (name == splitetext[0] || name == "")))

                //if (string.IsNullOrEmpty(name) || splitetext[0] == name)
                //    nameIsFound = true;
                //else
                //    nameIsFound = false;

                //if (string.IsNullOrEmpty(lastname) || splitetext[1] == lastname)
                //    lastnameIsFound = true;
                //else
                //    lastnameIsFound = false;

                //if (string.IsNullOrEmpty(email) || splitetext[6] == email)
                //    emailIsFound = true;
                //else
                //    emailIsFound = false;

                //ایندکس را بررسی کردیم که اگر بخشی از یک کلمه سرچ شد هم بتواند پیدا کند.
                if ((string.IsNullOrEmpty(name) || splitetext[0].IndexOf(name) >= 0)
                    && (string.IsNullOrEmpty(lastname) || splitetext[1].IndexOf(lastname) >= 0)
                    && (string.IsNullOrEmpty(email) || splitetext[6].IndexOf(email) >= 0))
                    isFound = true;
                else
                    isFound = false;

                //if (nameIsFound && lastnameIsFound && emailIsFound)
                if (isFound)
                {
                    oItem.FirstName = splitetext[0];
                    oItem.LastName = splitetext[1];
                    oItem.FatherName = splitetext[2];
                    oItem.NCode = splitetext[3];
                    oItem.Address = splitetext[4];
                    oItem.Tell = splitetext[5];
                    oItem.Email = splitetext[6];
                    oItem.Major = splitetext[7];
                    oItem.Education = splitetext[8];
                    oItem.Birthday = splitetext[9];
                    oItem.Gender = splitetext[10];
                    oItem.Extention = splitetext[11];

                    LItemFilter.Add(oItem);
                }
            }
            sr.Close();
        }
        catch
        {
            LItemFilter = null;
        }

        return LItemFilter;
    }

    public int Insert(UserInfoItem k)
    {
        int retval = 0;

        if (k.FirstName == "" || k.LastName == "" || k.FatherName == "" || k.NCode == "" || k.Address == "" || k.Tell == "" || k.Email == "" || k.Major == "" || k.Education == "" || k.Birthday == "" || k.Gender == "")
        {
            retval = -1;
        }
        if (retval == 0)
        {
            try
            {
                StreamWriter sw = new StreamWriter(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]), true);
                sw.WriteLine(k.FirstName + "," + k.LastName + "," + k.FatherName + "," + k.NCode + "," + k.Address + "," + k.Tell
                    + "," + k.Email + "," + k.Major + "," + k.Education + "," + k.Birthday + "," + k.Gender + "," + k.Extention);
                sw.Close();
            }
            catch (Exception ex)
            {
                retval = -2;
            }
        }
        return retval;
    }
    public List<UserInfoItem> GetAllData()
    {
        List<UserInfoItem> LItem = new List<UserInfoItem>();
        try
        {
            StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
            while (!sr.EndOfStream)
            {
                UserInfoItem oItem = new UserInfoItem();
                string i = sr.ReadLine();
                string[] splitetext = i.Split(',');
                oItem.FirstName = splitetext[0];
                oItem.LastName = splitetext[1];
                oItem.FatherName = splitetext[2];
                oItem.NCode = splitetext[3];
                oItem.Address = splitetext[4];
                oItem.Tell = splitetext[5];
                oItem.Email = splitetext[6];
                oItem.Major = splitetext[7];
                oItem.Education = splitetext[8];
                oItem.Birthday = splitetext[9];
                oItem.Gender = splitetext[10];
                oItem.Extention = splitetext[11];
                LItem.Add(oItem);

            }
            sr.Close();
        }
        catch
        {

        }
        return LItem;


    }
    public int NumberOfRejisterd()
    {
        StreamReader sabtenamiha = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
        int k = 0;
        while (sabtenamiha.Peek() > 0)
        {

            sabtenamiha.ReadLine();
            k++;

        }
        return k;
    }
    public bool CheckExistNCode(string nationalCode)
    {

        bool existed = false;
        StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
        while (!sr.EndOfStream)
        {
            string i = sr.ReadLine();
            string[] splitetext = i.Split(',');
            if (nationalCode == splitetext[3])
            {
                existed = true;
                break;
            }
        }
        sr.Close();
        return existed;
    }
    public bool logInByNCodeAndEmail(string emailaddress, string nationalCode)
    {
        bool loggedIn = false;
        StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
        while (!sr.EndOfStream)
        {
            string i = sr.ReadLine();
            string[] splitetext = i.Split(',');
            if (nationalCode == splitetext[3] && emailaddress == splitetext[6])
            {
                loggedIn = true;
                break;
            }
        }

        sr.Close();
        return loggedIn;
    }
    public UserInfoItem GetUserInfoByNCode(string nationalCode)
    {
        UserInfoItem oItem = new UserInfoItem();
        try
        {
            StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
            while (!sr.EndOfStream)
            {
                string i = sr.ReadLine();
                string[] splitetext = i.Split(',');
                if (nationalCode == splitetext[3])
                {
                    oItem.FirstName = splitetext[0];
                    oItem.LastName = splitetext[1];
                    oItem.FatherName = splitetext[2];
                    oItem.NCode = splitetext[3];
                    oItem.Address = splitetext[4];
                    oItem.Tell = splitetext[5];
                    oItem.Email = splitetext[6];
                    oItem.Major = splitetext[7];
                    oItem.Education = splitetext[8];
                    oItem.Birthday = splitetext[9];
                    oItem.Gender = splitetext[10];
                    oItem.Extention = splitetext[11];

                    oItem.IsFill = true;
                    break;
                }
            }
            sr.Close();

        }
        catch
        {

        }
        return oItem;

    }
    public UserInfoItem GetUserInfoByEmailAndNCode(string emailaddress, string nationalCode)
    {
        UserInfoItem oItem = new UserInfoItem();
        try
        {
            StreamReader sr = new StreamReader(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["LOG_PATH"]));
            while (!sr.EndOfStream)
            {
                string i = sr.ReadLine();
                string[] splitetext = i.Split(',');
                if (nationalCode == splitetext[3] && emailaddress == splitetext[6])
                {
                    oItem.FirstName = splitetext[0];
                    oItem.LastName = splitetext[1];
                    oItem.FatherName = splitetext[2];
                    oItem.NCode = splitetext[3];
                    oItem.Address = splitetext[4];
                    oItem.Tell = splitetext[5];
                    oItem.Email = splitetext[6];
                    oItem.Major = splitetext[7];
                    oItem.Education = splitetext[8];
                    oItem.Birthday = splitetext[9];
                    oItem.Gender = splitetext[10];
                    oItem.Extention = splitetext[11];

                    oItem.IsFill = true;

                    break;
                }
            }

            sr.Close();
        }
        catch (Exception)
        {

        }

        return oItem;
    }




}