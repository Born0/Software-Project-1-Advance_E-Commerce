using AdvancedECommerce.Repository;
using AdvanceECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvancedECommerce.Controllers.AdminControllers
{
    public class AdminController : Controller
    {
        private AdminRepository adminRepository = new AdminRepository();
        // GET: Admin
        public ActionResult Index()
        {
            List<Admin> admins = adminRepository.GetAll();
            return View(admins);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        public ActionResult AddAdmin(Admin admin)
        {
            if(ModelState.IsValid)
            {
                adminRepository.Insert(admin);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("AddAdmin");
            }
        }
    }
}