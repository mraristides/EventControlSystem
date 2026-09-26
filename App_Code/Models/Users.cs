using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// ///////////////////////////////////////////////
/// ///////// <!-- Code developed by Blind --> ////
/// ///////////////////// 我看你 ///////////////////
/// </summary>

/// <summary>
/// Summary description for Users
/// </summary>
/// 

public class Users
{
    DataClassesDataContext Database = new DataClassesDataContext();

    public object getAllUsers(int seasonID)
    {
        try
        {
            var Users = from x in Database.tb_users where x.season_id.Equals(seasonID) orderby x.nome select x;
            return Users;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public object getUsersPen(int seasonID)
    {
        try
        {
            var Users = from x in Database.tb_users where x.season_id.Equals(seasonID) && x.pagamento.Equals(0) select x;
            return Users;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public int getUserID(int seasonID, string value)
    {
        try
        {
            var userID = (from x in Database.tb_users where x.season_id.Equals(seasonID) && x.nome.Equals(value) select x.id).Single();
            return userID;
        }
        catch (Exception)
        {
            return 0;
        }
    }

    public bool DeleteUser(int seasonID, int userID)
    {
        try
        {
            var queryID = (from x in Database.tb_users where x.id.Equals(userID) select x).Single();
            var Controls = from control in Database.tb_controls where control.user_id.Equals(queryID.id) select control;

            foreach (var control in Controls)
            {
                if (control != null)
                {
                    var deleteControls = (from x in Database.tb_controls where x.id.Equals(control.id) select x).Single();
                    Database.tb_controls.DeleteOnSubmit(deleteControls);
                    Database.SubmitChanges();
                }
            }



            Database.tb_users.DeleteOnSubmit(queryID);
            Database.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public object QueryUsers(int seasonID, string value)
    {
        try
        {
            var query = from x in Database.tb_users where x.season_id.Equals(seasonID) && x.nome.Contains(value) select x;
            return query;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public bool UsersPago(int seasonID, int UserID)
    {
        try
        {
            var query = (from x in Database.tb_users where x.id.Equals(UserID) orderby x.nome select x).Single();
            query.pagamento = 1;
            Database.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public tb_user getUser(int UserID)
    {
        try
        {
            var query = (from x in Database.tb_users where x.id.Equals(UserID) select x).Single();
            return query;
        }
        catch
        {
            return null;
        }
    }
    
   
}