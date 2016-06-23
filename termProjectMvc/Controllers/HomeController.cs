using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using termProjectMvc.Models;
using termProjectMvc.Controllers;
namespace termProjectMvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Database1Entities1 cx = new Database1Entities1();
        ISign usr;
        
        public HomeController(ISign u)
        {
            usr = u;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult aboutus()
        {
            return View();
        }
        public ViewResult contactus()
        {
            return View();
        }
        public ViewResult feedback()
        {
            return View();
        }
        public ViewResult login()
        {
            return View();
        }
        public ViewResult signup()
        {
            return View();
        }
        public ViewResult csignup()
        {
            return View();
        }
        public JsonResult CheckUserName()
        {

            string email = Request["em"];
            bool flag = false;
            flag = cx.user1.Any(x => x.email == email);

            return this.Json(flag, JsonRequestBehavior.AllowGet);

        }
        
        [HttpPost]
        public ActionResult addMember(user1 user)
        {

            if (ModelState.IsValid)
            {
                usr.save(user);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("signup");
            }
           
        }
        [HttpPost]
        public ActionResult addCompany(company c)
        {

            if (ModelState.IsValid)
            {
                usr.saveC(c);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("signup");
            }

        }

        [HttpPost]
        public void addQuestion(question q)
        {
            cx.questions.Add(q);
            cx.SaveChanges();
        }
     

        public ActionResult validate(user1 user)
        {
            bool flag = cx.user1.Any(x => x.email == user.email && x.password == user.password);
            bool flag2 = cx.companies.Any(x => x.email == user.email && x.password == user.password);
            if (flag2)
            {
                return Redirect("~/Admin/adminView");
            }
            else if(flag)
            {
                Session["userID"] = user.Id;
                return Redirect("~/Admin/userView");
            }
            return RedirectToAction("login");
        }
        
    }
}
