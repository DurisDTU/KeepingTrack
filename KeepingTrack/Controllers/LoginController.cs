using KeepingTrack.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeepingTrack.Controllers
{
    public class LoginController : Controller
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=KeepingTrackDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "username, password")] Member member)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                SqlCommand select = new SqlCommand("SELECT count(*) FROM users WHERE username = '" + member.username + "' AND password = '" + member.password +"'", connect);
                connect.Open();
                SqlDataReader reader = select.ExecuteReader();

                while(reader.Read())
                {
                    if (reader.GetInt32(0) == 0)
                    {
                        ViewBag.Message = "Invalid login.";
                    } else {
                        return RedirectToAction("MainPage", "VerifiedUser");
                    }
                }
            }

            return View();
        }
            

    }
}