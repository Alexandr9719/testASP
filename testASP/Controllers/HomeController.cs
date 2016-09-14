using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testASP.Models;
using Domain.Entities; 

namespace testASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Times()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DataBase()
        {
            dbUsersContext rep = new dbUsersContext();
            //dbGroupsContext repUsers = new dbGroupsContext();
            return View(rep.getUsers());
        }
    }
}