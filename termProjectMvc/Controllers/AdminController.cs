using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using termProjectMvc.Models;

namespace termProjectMvc.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        Database1Entities1 cx = new Database1Entities1();
        public ActionResult viewDetail()
        {
            return View();
        }
        public ActionResult pool()
        {
            List<question> li = new List<question>();
            li = cx.questions.ToList();
            return View(li);
        }
        public ActionResult adminView()
        {
            return View();
        }
        public ActionResult userView()
        {
            List<score> li = new List<score>();
            li = (cx.scores.ToList());
            Random rnd = new Random();
            int score1 = rnd.Next(1, 6); // creates
            ViewBag.score = li.ElementAt(li.Count-1).score1;

            return View();
        }
        public ActionResult solveTest()
        {
            List<question> li = new List<question>();
            li = cx.questions.ToList();
            return View(li);
        }
        [HttpPost]
        public ActionResult validater()
        {
            int count = 0;
            List<question> list = cx.questions.ToList();
            for (int i = 0; i < cx.questions.Count(); i++ )
            {
                string temp = Request["option"+i];
                if(list.ElementAt(i).answer == int.Parse(temp))
                {
                    count++;
                }
            }
            score scr = new score();
            List<score> scoredata = cx.scores.ToList();
            scr.Id = scoredata.Count + 1;
            scr.score1 = count;
            //scr.userId = int.Parse(Session["userID"].ToString());
            
            cx.scores.Add(scr);
            cx.SaveChanges();

            return RedirectToAction("userView");
        }
        public ActionResult search()
        {
            return View();
        }
        public ActionResult postTest()
        {
            return View();
        }

    }
}
