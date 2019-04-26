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
        // GET: Login
        
        public ActionResult Login()
        {
            return View();
        }

        
    }
}