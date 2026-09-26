using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class control_users_Edit : System.Web.UI.Page
{
    private Command Cmd = new Command();
    private Users Users = new Users();
    private Eventos Eventos = new Eventos();
    private Controls Control = new Controls();
    private Doc doc = new Doc();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["SEASON"] != null)
        {
            int SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
            if (Request["__EVENTARGUMENT"] != null && Request["__EVENTARGUMENT"] == "eventUserList")
            {
                if (eventsUserList.SelectedValue != null)
                {
                    if (Request.Cookies["UsersEdit"] != null)
                    {
                        string EventEdit = Request.Cookies["UsersEdit"].Value;
                        if (EventEdit == "1")
                        {
                            if (Request.Cookies["UserID"] != null)
                            {
                                string UserID = Request.Cookies["UserID"].Value;
                                var EventID = Eventos.getEventID(SeasonID, eventsUserList.SelectedValue);
                                if (EventID != 0)
                                {
                                    bool DeleteControl = Control.DeleteControl(Convert.ToInt32(UserID), EventID);
                                    if (DeleteControl == true)
                                    {
                                        EventDownList.Items.Add(eventsUserList.SelectedValue);
                                        eventsUserList.Items.Remove(eventsUserList.SelectedValue);
                                    }
                                }
                                
                            }
                        }
                        else if (EventEdit == "0")
                        {
                            var EventID = Eventos.getEventID(SeasonID, eventsUserList.SelectedValue);
                            if (EventID != 0)
                            {
                                EventDownList.Items.Add(eventsUserList.SelectedValue);
                                eventsUserList.Items.Remove(eventsUserList.SelectedValue);
                            }
                        }
                    }
                }
            }
            eventsUserList.Attributes.Add("ondblclick", ClientScript.GetPostBackEventReference(eventsUserList, "eventUserList"));

            if (!IsPostBack)
            {
                if (Request.Cookies["UsersEdit"] != null)
                {
                    string EventEdit = Request.Cookies["UsersEdit"].Value;                    
                    if (EventEdit == "0")
                    {
                        submitButton.Text = "Registrar";
                        EditNomeLabel.Text = "Cadastro de Participante";

                        var eventos = Eventos.getAllEvents(SeasonID);
                        EventDownList.DataSource = eventos;
                        EventDownList.DataTextField = "nome";
                        EventDownList.DataBind();
                    }
                    else if (EventEdit == "1")
                    {
                        if (Request.Cookies["UserID"] != null)
                        {
                            string UserID = Request.Cookies["UserID"].Value;
                            submitButton.Text = "Editar";
                            EditNomeLabel.Text = "Editar Participante";
                            var user = Users.getUser(Convert.ToInt32(UserID));
                            nomeText.Text = user.nome;
                            rgText.Text = user.rg;
                            telefoneText.Text = user.telefone;
                            celularText.Text = user.celular;
                            emailText.Text = user.email;
                            cursoText.Text = user.curso;
                            periodoText.Text = Convert.ToString(user.periodo);
                            ensinoText.Text = user.ensino;
                            DownListMembro.SelectedValue = Convert.ToString(user.membro);
                            DownListPagamento.SelectedValue = Convert.ToString(user.pagamento);
                            HorasLabel.Text = Convert.ToString(user.horas_total);


                            DataClassesDataContext Database = new DataClassesDataContext();
                            var events = from x in Database.tb_events where x.season_id.Equals(SeasonID) select x;
                            foreach (var eList in events)
                            {
                                string eName = eList.nome;
                                var eventUser_ID = (from x in Database.tb_controls where x.user_id.Equals(UserID) && x.event_id.Equals(eList.id) select x.event_id.ToString()).FirstOrDefault();
                                if (eList.id == Convert.ToInt32(eventUser_ID))
                                {
                                    eventsUserList.Items.Add(eName);
                                }
                                else
                                {
                                    EventDownList.Items.Add(eName);
                                }
                            }


                        }
                    }
                }
            }
        }
    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["SEASON"] != null)
        {
            int SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
            if (Request.Cookies["UsersEdit"] != null)
            {
                string UsersEdit = Request.Cookies["UsersEdit"].Value;
                DataClassesDataContext Database = new DataClassesDataContext();
                if (UsersEdit == "0")
                {
                    int CheckUser = Users.getUserID(SeasonID, nomeText.Text);
                    if (CheckUser != 0)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", Convert.ToString(Cmd.Msg("Ja Existe um participante com esse nome")), false);
                    }
                    else
                    {
                        tb_user tb_user = new tb_user();
                        tb_user.nome = nomeText.Text;
                        tb_user.rg = rgText.Text;
                        tb_user.telefone = telefoneText.Text;
                        tb_user.celular = celularText.Text;
                        tb_user.curso = cursoText.Text;
                        tb_user.email = emailText.Text;
                        tb_user.ensino = ensinoText.Text;
                        if (!string.IsNullOrEmpty(periodoText.Text))
                        {
                            tb_user.periodo = Convert.ToInt32(periodoText.Text);
                        }
                        else
                        {
                            tb_user.periodo = 0;
                        }
                        tb_user.membro = Convert.ToByte(DownListMembro.SelectedValue);
                        tb_user.pagamento = Convert.ToByte(DownListPagamento.SelectedValue);
                        tb_user.season_id = SeasonID;
                        tb_user.horas_total = "0";

                        Database.tb_users.InsertOnSubmit(tb_user);
                        Database.SubmitChanges();

                        foreach (var listBoxItem in eventsUserList.Items)
                        {
                            tb_control tb_control = new tb_control();
                            var customer = (from x in Database.tb_events where x.season_id.Equals(SeasonID) && x.nome.Equals(listBoxItem.ToString()) select x).Single();
                            tb_control.event_id = Convert.ToInt32(customer.id);
                            tb_control.user_id = tb_user.id;
                            tb_control.checkin = 0;
                            if (customer.event_check == 1)
                            {
                                double hours = Convert.ToDouble(customer.event_time);
                                tb_control.horas = Convert.ToString(hours);
                                var User = (from x in Database.tb_users where x.id.Equals(tb_user.id) select x).Single();
                                double result = Convert.ToDouble(User.horas_total) + hours;
                                User.horas_total  = Convert.ToString(result);
                            }
                            Database.tb_controls.InsertOnSubmit(tb_control);
                            Database.SubmitChanges();
                        }

                        
                        Response.Redirect("~/Participantes");
                    }

                }
                else if (UsersEdit == "1")
                {
                    if (Request.Cookies["UserID"] != null)
                    {
                        string UserID = Request.Cookies["UserID"].Value;

                        var customer = (from x in Database.tb_users where x.id.Equals(UserID) select x).FirstOrDefault();
                        customer.nome = nomeText.Text;
                        customer.rg = rgText.Text;
                        customer.telefone = telefoneText.Text;
                        customer.celular = celularText.Text;
                        customer.curso = cursoText.Text;
                        customer.email = emailText.Text;
                        customer.ensino = ensinoText.Text;
                        if (!string.IsNullOrEmpty(periodoText.Text))
                        {
                            customer.periodo = Convert.ToInt32(periodoText.Text);
                        }
                        else
                        {
                            customer.periodo = 0;
                        }
                        customer.membro = Convert.ToByte(DownListMembro.SelectedValue);
                        customer.pagamento = Convert.ToByte(DownListPagamento.SelectedValue);

                        Database.SubmitChanges();


                        Response.Redirect("~/Participantes");
                    }
                }                    
            }
        }
    }

    protected void eventsList_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        
    }

    protected void eventList_DoubleClick(object sender, EventArgs e)
    {
    }

    protected void addEventButton_Click(object sender, EventArgs e)
    {

        if (Request.Cookies["SEASON"] != null)
        {
            int SeasonID = Convert.ToInt32(Request.Cookies["SEASON"].Value);
            DataClassesDataContext Database = new DataClassesDataContext();
            if (EventDownList.SelectedValue != null)
            {
                if (Request.Cookies["UsersEdit"] != null)
                {
                    string UsersEdit = Request.Cookies["UsersEdit"].Value;
                    if (UsersEdit == "1")
                    {
                        if (Request.Cookies["UserID"] != null)
                        {
                            string UserID = Request.Cookies["UserID"].Value;

                            int CheckADD = Eventos.getEventID(SeasonID, EventDownList.SelectedValue);
                            if (CheckADD != 0)
                            {
                                var EventID = (from x in Database.tb_events where x.season_id.Equals(SeasonID) && x.nome.Equals(EventDownList.SelectedValue) select x).Single();
                                tb_control Control = new tb_control();
                                Control.user_id = Convert.ToInt32(UserID);
                                Control.event_id = Convert.ToInt32(EventID.id);
                                Control.checkin = 0;
                                if (EventID.event_check == 1)
                                {
                                    double hours = Convert.ToDouble(EventID.event_time);
                                    Control.horas = Convert.ToString(hours);
                                    var User = (from x in Database.tb_users where x.id.Equals(UserID) select x).Single();
                                    double result = Convert.ToDouble(User.horas_total) + hours;
                                    User.horas_total = Convert.ToString(result);
                                    Database.SubmitChanges();
                                }

                                Database.tb_controls.InsertOnSubmit(Control);
                                Database.SubmitChanges();                         


                                eventsUserList.Items.Add(EventDownList.SelectedValue);
                                EventDownList.Items.Remove(EventDownList.SelectedValue);

                            }
                        }

                    }
                    else if (UsersEdit == "0")
                    {
                        int EventCheck = Eventos.getEventID(SeasonID, EventDownList.SelectedValue);
                        if (EventCheck != 0)
                        {
                            eventsUserList.Items.Add(EventDownList.SelectedValue);
                            EventDownList.Items.Remove(EventDownList.SelectedValue);
                        }
                    }
                 }                
            }
        }
    }

    protected void backButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Participantes");
    }

    protected void AbrirCrachar_Click(object sender, EventArgs e)
    {
        string UserID = Request.Cookies["UserID"].Value;
        string Season = Request.Cookies["SEASON"].Value;
        tb_user usertb = Users.getUser(Convert.ToInt32(UserID));
        string MapPath = Server.MapPath("..\\..\\lib\\img\\certificados\\");
        doc.CracharUnico(usertb, MapPath);
        Response.Redirect("~/Seasons/season" + Season + "/users/Crachar_"+usertb.nome.Replace(" ", "")+".pdf");
    }

    protected void AbrirCertificado_Click(object sender, EventArgs e)
    {
        string UserID = Request.Cookies["UserID"].Value;
        string Season = Request.Cookies["SEASON"].Value;
        tb_user usertb = Users.getUser(Convert.ToInt32(UserID));
        string MapPath = Server.MapPath("..\\..\\lib\\img\\certificados\\");
        doc.CertificadoUnico(usertb, MapPath);
        Response.Redirect("~/Seasons/season" + Season + "/users/Certificado_" + usertb.nome.Replace(" ", "") + ".pdf");
    }
}