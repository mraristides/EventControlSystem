using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
/// <summary>
/// ///////////////////////////////////////////////
/// ///////// <!-- Code developed by Blind --> ////
/// ///////////////////// 我看你 ///////////////////
/// </summary>

/// <summary>
/// Summary description for Season
/// </summary>
public class Season
{
    private Where where = new Where();
    private DataClassesDataContext Database = new DataClassesDataContext();

    /// <summary>
    /// get season. return tb_season value
    /// </summary>
    /// <param name="SeasonID"></param>
    /// <returns></returns>
    public tb_season getSeason(int SeasonID)
    {
        try
        {
            var season = (from x in Database.tb_seasons where x.ID.Equals(SeasonID) select x).Single();
            return season;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public int getSeasonID(string SeasonName)
    {
        try
        {
            var season = (from x in Database.tb_seasons where x.Nome.Equals(SeasonName) select x.ID).Single();
            return season;
        }
        catch (Exception)
        {
            return 0;
        }

    }

    public object getallSeason()
    {
        try
        {
            var seasons = from x in Database.tb_seasons select x;
            return seasons;
        }
        catch (Exception)
        {
            return null;
        }
    }

    /// <summary>
    /// delete season
    /// </summary>
    /// <param name="SeasonID"></param>
    /// <returns>return bool value</returns>
    public bool deleteSeason(int SeasonID)
    {
        try
        {
            var eventsItem = from x in Database.tb_events where x.season_id.Equals(SeasonID) select x.id;
            foreach (var eventItem in eventsItem)
            {
                var deleteEvent = (from x in Database.tb_events where x.id.Equals(Convert.ToInt32(eventItem)) select x).Single();
                Database.tb_events.DeleteOnSubmit(deleteEvent);
                Database.SubmitChanges();
            }

            var users = from x in Database.tb_users where x.season_id.Equals(SeasonID) select x.id;
            foreach (var user in users)
            {
                var controls = from x in Database.tb_controls where x.user_id.Equals(Convert.ToInt32(user)) select x.id;
                foreach (var control in controls)
                {
                    var deleteControl = (from x in Database.tb_controls where x.id.Equals(Convert.ToInt32(control)) select x).Single();
                    Database.tb_controls.DeleteOnSubmit(deleteControl);
                    Database.SubmitChanges();
                }

                var deleteUser = (from x in Database.tb_users where x.id.Equals(Convert.ToInt32(user)) select x).Single();
                QRCode Qr = new QRCode();
                Database.tb_users.DeleteOnSubmit(deleteUser);
                Database.SubmitChanges();
            }

            var season = (from x in Database.tb_seasons where x.ID.Equals(SeasonID) select x).Single();

            Database.tb_seasons.DeleteOnSubmit(season);
            Database.SubmitChanges();

            Directory.Delete(where.FolderSeason(Convert.ToString(SeasonID)), true);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="SeasonID"></param>
    /// <returns></returns>
    public string[] getCountUsers(int SeasonID)
    {
        try
        {
            var users = from x in Database.tb_users where x.season_id.Equals(SeasonID) select x;
            int Userscount = 0;
            int Userspago = 0;
            int Userspendente = 0;
            foreach (var CountUsers in users)
            {
                Userscount++;
                if (CountUsers.pagamento == 0)
                {
                    Userspendente++;
                }
                else
                {
                    Userspago++;
                }
            }
            string[] Counts = new string[3];
            Counts[0] = Userscount.ToString();
            Counts[1] = Userspago.ToString();
            Counts[2] = Userspendente.ToString();
            return Counts;
        }
        catch
        {
            return null;
        }
    }

    public void CreateFolder(string SeasonID)
    {
        string folderCRUsers = where.FolderSeasonUsers(SeasonID);
        string folderCR = where.FolderSeason(SeasonID);
        if (!Directory.Exists(folderCR))
        {
            Directory.CreateDirectory(folderCR);
        }
        else if (!Directory.Exists(folderCRUsers))
        {
            Directory.CreateDirectory(folderCRUsers);
        }
    }
}