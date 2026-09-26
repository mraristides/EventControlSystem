using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
/// <summary>
/// Summary description for Where
/// </summary>
public class Where
{
    private string PathSeason = ConfigurationManager.ConnectionStrings["PathCertificados"].ConnectionString;
    public string URL = ConfigurationManager.ConnectionStrings["URL"].ConnectionString;

    public string FolderSeason(string ID)
    {
        string folderCR = PathSeason + "season" + ID + "\\";
        return folderCR;
    }

    public string FolderSeasonUsers(string ID)
    {
        string folderCR = PathSeason + "season" + ID + "\\users\\";
        return folderCR;
    }




}