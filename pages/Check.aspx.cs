 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Check : System.Web.UI.Page
{
    private DataClassesDataContext Database = new DataClassesDataContext();
    private string ReturnCheckin;
    private int ControlID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            string getID = Request.QueryString["id"];
            tb_user User = getUser(Convert.ToInt32(getID));
            if (User != null)
            {
                LabelNome.Text = User.nome;
                tb_control Control = getControl(User.id);
                if (Control != null)
                {
                    if (Control.checkin == 0)
                    {
                        EntradaButton.Visible = true;
                    }
                    else if (Control.checkin == 1)
                    {
                        SaidaButton.Visible = true;
                    }
                    Eventos Eventos = new Eventos();
                    var evento = Eventos.getEvent(Convert.ToInt32(User.season_id), Convert.ToInt32(Control.event_id));
                    LabelEvento.Text = evento.nome;
                    ControlID = Control.id; 
                } 
                else
                {
                    LabelCheckin.Text = "O Evento não começou"; 
                }
                
            }
            else
            {
                LabelNome.Text = "Participante não existe";
                LabelCheckin.Text = "O Evento não começou";
            }
        }    
        

    }

    protected void SaidaButton_Click(object sender, EventArgs e)
    {
        ReturnCheckin = CheckinControl(ControlID);
        LabelCheckin.Text = "Participante saiu as " + Convert.ToString(DateTime.Now.ToString("HH:mm"));
        SaidaButton.Visible = false;
    }
    protected void EntradaButton_Click(object sender, EventArgs e)
    {
        ReturnCheckin = CheckinControl(ControlID);
        LabelCheckin.Text = "Participante entrou as " + Convert.ToString(DateTime.Now.ToString("HH:mm"));
        EntradaButton.Visible = false;
    }

    public string CheckinControl(int ID)
    {
        try
        {
            var Control = (from x in Database.tb_controls where x.id.Equals(ID) select x).Single();
            tb_event Event = getEvent(Convert.ToInt32(Control.event_id));
            if (Event.event_check == 0)
            {
                int Check = Convert.ToInt32(Control.checkin);
                if (Check == 0)
                {
                    Control.entrada = DateTime.Now;
                    Control.checkin = 1;
                    DateTime InicioEvento = DateTime.Now.Date;
                    InicioEvento = InicioEvento.AddHours(TimeSpan.Parse(Event.time.ToString()).Hours);
                    InicioEvento = InicioEvento.AddMinutes(TimeSpan.Parse(Event.time.ToString()).Minutes);
                    Control.horasLiberado = InicioEvento.AddMinutes(Convert.ToDouble(Event.duracao));
                    Database.SubmitChanges();
                    return "1";
                }
                else if (Check == 1)
                {
                    double hours = Convert.ToDouble(Event.event_time.ToString());
                    Control.saida = DateTime.Now;
                    DateTime Entrada = DateTime.Parse(Control.entrada.ToString());       
                    TimeSpan Total = TimeSpan.Parse(DateTime.Now.ToShortTimeString()) - TimeSpan.Parse(Entrada.ToShortTimeString());
                    Control.horasTotal = Total;
                    if (Control.saida < Control.horasLiberado)
                    {
                        double hoursF = hours / 2;
                        Control.horas = Convert.ToString(Convert.ToInt32(hoursF));
                    }
                    else
                    {
                        Control.horas = Convert.ToString(hours);
                    }
                    Control.checkin = 2;
                    var customerUser = (from x in Database.tb_users where x.id.Equals(Control.user_id) select x).Single();
                    double result = Convert.ToDouble(customerUser.horas_total) + Convert.ToDouble(Control.horas);
                    customerUser.horas_total = Convert.ToString(result);
                    Database.SubmitChanges();
                    return "0";
                }
                else
                {
                    return null;
                }
            }
            return null;

        }
        catch (Exception)
        {
            return null;
        }

        
    }


    public tb_control getControl(int ID)
    {

        try
        {
            var customer = from x in Database.tb_controls where x.user_id.Equals(ID) select x;

            foreach (var control in customer)
            {
                int Check = Convert.ToInt32(control.checkin);
                if (Check != 2)
                {
                    tb_event Event = getEvent(Convert.ToInt32(control.event_id));                    
                    string DateNow = DateTime.Now.Date.ToString();
                    string TimeNow = DateTime.Now.ToShortTimeString();
                    string DateEvent = Convert.ToString(Event.date);
                    string TimeEvent = Convert.ToString(Event.time);
                    if (Convert.ToDateTime(DateNow) == Convert.ToDateTime(DateEvent))
                    {
                        if (TimeSpan.Parse(TimeNow) >= TimeSpan.Parse(TimeEvent))
                        {                               
                            return control;
                        }
                    }      
                }    
            }

            return null;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public tb_event getEvent(int EventID)
    {

        try
        {
            var customer = (from x in Database.tb_events where x.id.Equals(EventID) select x).Single();
            if (customer.id == EventID)
            {
                return customer;
            }
            else
            {
                return null;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public tb_user getUser(int ID)
    {
        try
        {
            var customer = (from x in Database.tb_users where x.id.Equals(ID) select x).Single();
            if (customer.id == ID)
            {
                return customer;                
            }
            else
            {
                return null;
            }
        }
        catch (Exception)
        {

            return null;
        }

    }






    
}