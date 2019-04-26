using KeepingTrack.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeepingTrack.Controllers
{
    public class CreateNewMemberController : Controller
    {

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=KeepingTrackDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult CreateMember()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult CreateMember([Bind(Include = "username, name, password, email")] Member member)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                SqlCommand create = new SqlCommand("INSERT INTO users(username, name, password, email) VALUES('" + member.username + "', '" + member.name + "', '" + member.password + "', '" + member.email + "')", connect);
                connect.Open();
                create.ExecuteNonQuery();
            }
            return RedirectToAction("Login", "Login", new {area = "" });
        }

    }
}