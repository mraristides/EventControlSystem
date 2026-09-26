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
/// Summary description for Controls
/// </summary>
public class Controls
{
    DataClassesDataContext Database = new DataClassesDataContext();
    public bool DeleteControl(int UserID, int EventID)
    {
        try
        {
            var Customer = (from x in Database.tb_controls where x.user_id.Equals(UserID) && x.event_id.Equals(EventID) select x).Single();
            if (Customer.horas != null)
            {
                var User = (from x in Database.tb_users where x.id.Equals(UserID) select x).Single();
                double horastotal = Convert.ToDouble(User.horas_total);
                double horasevento = Convert.ToDouble(Customer.horas);
                double result = horastotal - horasevento;
                User.horas_total = Convert.ToString(result);
                Database.SubmitChanges();
            }
            Database.tb_controls.DeleteOnSubmit(Customer);
            Database.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

}