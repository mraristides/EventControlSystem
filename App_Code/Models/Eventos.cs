using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Events
/// </summary>
public class Eventos
{    
    private DataClassesDataContext Database = new DataClassesDataContext();
    
    public bool InsertEvent(tb_event tb_event)
    {
        try
        {
            Database.tb_events.InsertOnSubmit(tb_event);
            Database.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    /// <summary>
    /// get all event by season. return object table
    /// </summary>
    /// <param name="SeasonID"></param>
    /// <returns>return object table</returns>
    public object getAllEvents(int SeasonID)
    {
        try
        {
            var table = from x in Database.tb_events where x.season_id.Equals(SeasonID) select x;
            return table;
        }
        catch (Exception)
        {
            return null;
        }

    }

    /// <summary>
    /// get event by value. return object event
    /// </summary>
    /// <param name="SeasonID"></param>
    /// <param name="EventID"></param>
    /// <returns></returns>
    public tb_event getEvent(int SeasonID, int EventID)
    {
        try
        {
            var query = (from x in Database.tb_events where x.season_id.Equals(SeasonID) && x.id.Equals(EventID) select x).Single();
            return query;
        }
        catch
        {
            return null;
        }
    }


    /// <summary>
    /// get eventID by value. return object eventID
    /// </summary>
    /// <param name="SeasonID"></param>
    /// <param name="value"></param>
    /// <returns>return object eventID</returns>
    public int getEventID(int SeasonID, string value)
    {
        try
        {
            var query = (from x in Database.tb_events where x.season_id.Equals(SeasonID) && x.nome.Equals(value) select x.id).Single();
            return query;
        }
        catch (Exception)
        {
            return 0;
        }
    }

    /// <summary>
    /// delete event
    /// </summary>
    /// <param name="SeasonID"></param>
    /// <param name="value"></param>
    /// <returns>return bool value</returns>
    public bool deleteEvent(int eventID)
    {
        try
        {
            var query = (from x in Database.tb_events where x.id.Equals(eventID) select x).Single();
            Database.tb_events.DeleteOnSubmit(query);
            Database.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public object queryEvent(int seasonID, string value)
    {
        try
        {
            var query = from x in Database.tb_events where x.season_id.Equals(seasonID) && x.nome.Contains(value) select x;
            return query;
        }
        catch (Exception)
        {
            return null;
        }
    }


   


}