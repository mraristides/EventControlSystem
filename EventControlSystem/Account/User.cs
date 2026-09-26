using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace EventControlSystem.Account
{
    public class User
    {
        private DataClassesDataContext Database = new DataClassesDataContext();

        public static int ID { get; set; }
        public static string Nome { get; set; }
        public static string Login { get; set; }
        public static string Senha { get; set; }
        public static string Acesso { get; set; }
        public static bool Status { get; set; }
        public static DateTime UltimoAcesso { get; set; }

        public static bool LEITURA { get; set; }
        public static bool EDITAR { get; set; }
        public static bool CRIAR { get; set; }
        public static bool DELETAR { get; set; }
        public static bool ADMIN { get; set; }



        public bool CheckUser(string User, string Password)
        {
            try
            {
                var HasUser = (from x in Database.tb_logins where x.Login.Equals(User) && x.Senha.Equals(Password) select x).Single();
                if (HasUser.Login == User)
                {
                    if (HasUser.Senha == Password)
                    {
                        ID = HasUser.ID;
                        Nome = HasUser.Nome;
                        Login = HasUser.Login;
                        Senha = HasUser.Senha;
                        string StrUltimoAcesso = Convert.ToString(HasUser.UlitmoAcesso);
                        if (string.IsNullOrEmpty(StrUltimoAcesso))
                        {
                            UltimoAcesso = DateTime.Now;
                        }
                        else
                        {
                            UltimoAcesso = DateTime.Parse(StrUltimoAcesso);
                        }
                        Status = true;
                        Entrada();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } 
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }

        }
        
        // Registro de Entrada
        public void Entrada()
        {
            tb_log_login log = new tb_log_login();
            log.LoginID = ID;
            log.Nome = Nome;
            log.Evento = "ENTROU";
            log.Tempo = DateTime.Now;
            Database.tb_log_logins.InsertOnSubmit(log);
            Database.SubmitChanges();

            try
            {
                var tbLogin = (from x in Database.tb_logins where x.ID.Equals(ID) select x).Single();
                tbLogin.UserStatus = 1;
                tbLogin.UlitmoAcesso = DateTime.Now;
                Database.SubmitChanges();
            }
            finally
            {

            }
            


            Status = true;
        }

        // Registro de Saida
        public void Saida()
        {
            tb_log_login log = new tb_log_login();
            log.LoginID = ID;
            log.Nome = Nome;
            log.Evento = "SAIU";
            log.Tempo = DateTime.Now;
            Database.tb_log_logins.InsertOnSubmit(log);
            Database.SubmitChanges();

            try
            {
                var tbLogin = (from x in Database.tb_logins where x.ID.Equals(ID) select x).Single();
                tbLogin.UserStatus = 0;
                Database.SubmitChanges();
            }
            finally
            {

            }



            Status = false;
        }


    }
}
