
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CRUD_Operations.Models;
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace CRUD_Operations.Controllers
{
    public class LoginController : Controller
    {

        MyDbContext db = new MyDbContext();
       

        [HttpPost]
        public IActionResult Login([Bind] Admins Admin)
        {
            Admins d = db.Admins.Where(s => s.Name == Admin.Name).FirstOrDefault();
    
            if(d != null)
            {
                if (d.Password == Admin.Password && d.Name == Admin.Name)
                    return RedirectToAction("Index", "Student");
                else
                    return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
             

        }
    }
}
