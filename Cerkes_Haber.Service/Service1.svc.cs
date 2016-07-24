using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Cerkes_Haber.Models.Models;
using System.Data.SqlClient;

namespace Cerkes_Haber.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private Helper.BaseHelper h = new Helper.BaseHelper();


        /// <summary>
        /// user login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool Login(Login login)
        {
            try
            {
                string comStr = "select UserName,Pasasword from Login where UserName=@username and Pasasword=@pass";
                SqlCommand command = new SqlCommand(comStr, h.SqlClient);
                command.Parameters.AddWithValue("@username", login.UserName);
                command.Parameters.AddWithValue("@pass", login.Password);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)                
                    return true;                
                else               
                    return false;
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// user saves
        /// </summary>
        /// <param name="user">user instance</param>
        /// <returns></returns>
        public bool SaveUSer(User user)
        {
            try
            {
                var insertLoginStr = "insert into Login values (@UserID,@UserName,@Pass)";
                var inserUsersStr = "insert into Users values(@UserID,@NameSurname,@City,@Village,@Mail,@Phone,@address,@part,@imageurl)";

                SqlCommand commandLogin = new SqlCommand(insertLoginStr, h.SqlClient);
                SqlCommand commandUsers = new SqlCommand(inserUsersStr, h.SqlClient);

                commandLogin.Parameters.AddWithValue("@UserID", user.UserID);
                commandLogin.Parameters.AddWithValue("@UserName", user.UserName);
                commandLogin.Parameters.AddWithValue("@Pass", user.Password);


                commandUsers.Parameters.AddWithValue("@UserID", user.UserID);
                commandUsers.Parameters.AddWithValue("@NameSurname", user.NameSurname);
                commandUsers.Parameters.AddWithValue("@City", user.City);
                commandUsers.Parameters.AddWithValue("@Village", user.Village);
                commandUsers.Parameters.AddWithValue("@Mail", user.Mail);
                commandUsers.Parameters.AddWithValue("@Phone", user.Phone);
                commandUsers.Parameters.AddWithValue("@address", user.Address);
                commandUsers.Parameters.AddWithValue("@part", user.Part);
                commandUsers.Parameters.AddWithValue("@imageurl", user.ImageUrl);

                commandLogin.ExecuteNonQuery();
                commandUsers.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



    }
}
