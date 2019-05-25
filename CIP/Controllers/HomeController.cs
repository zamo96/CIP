using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CIP.Models;
namespace CIP.Controllers
{
    public class HomeController : Controller
    {
        // Just check github
        PhaseContext db = new PhaseContext();
        TestContext td = new TestContext();
        Cip1_LineContext cip = new Cip1_LineContext();
        CommentContext com = new CommentContext();
        public ActionResult Index(DateTime? time)
        {
            if (time == null)
            {
                DateTime dateTime = DateTime.Now;
                return View(dateTime);
            }
            return View(time);
        }
        public PartialViewResult Circle(string time)
        {
            DateTime myDate = DateTime.Parse(time);
            List<Cip1_Line> lstModel = cip.Cip1_Lines.Where(x => x.Date.Day == myDate.Day && x.Date.Month == myDate.Month && x.Date.Year == myDate.Year).ToList();

            return PartialView("Circle", lstModel);
        }
        [HttpPost]
        public ActionResult Create(string obj, string commentary, int priority, string dateTime)
        {
            DateTime myDate = DateTime.Parse(dateTime);
            CIP.Models.Comment comment = new CIP.Models.Comment();

            comment.Object = obj;
            comment.Priority = priority;
            comment.Commentary = commentary;
            comment.Date = myDate;
            com.Comments.Add(comment);
            com.SaveChanges();

            return RedirectToAction("Index");
        }

        public PartialViewResult Update()
        {

            List<Phase> model = db.Phases.ToList();
            //List<Cip1_Line> model = cip.Cip1_Lines.ToList();
            return PartialView("Phases", model);
        }
        public PartialViewResult UpdateCircle()
        {
            List<Phase> model = db.Phases.Where(x => x.Id < 5).ToList();
            return PartialView("Circle", model);
        }
        public PartialViewResult UpdateTime(string time)
        {
            DateTime myDate = DateTime.Parse(time);
            List<Test> model = td.Tests.Where(x => x.Date < myDate).ToList();
            return PartialView("Time", model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Comments()
        {

            List<Comment> comm = com.Comments.OrderBy(x => x.Date).ToList();
            return View(comm);
        }
        public PartialViewResult CommentsWithFilters(string filter)
        {
            List<Comment> commentaries = new List<Comment>();
            if (filter == "Все объекты")
            {
                commentaries = com.Comments.OrderBy(x => x.Date).ToList();
            }
            else
                commentaries = com.Comments.Where(x => Equals(x.Object, filter)).OrderBy(x => x.Date).ToList();
            return PartialView(commentaries);
        }
        [HttpGet]
        public ActionResult EditComment(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Comment commentary = com.Comments.Find(id);
            if (commentary != null)
            {
                return PartialView(commentary);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult EditComment(Comment comment)
        {
            com.Entry(comment).State = EntityState.Modified;
            com.SaveChanges();
            return RedirectToAction("Comments");
        }
        public ActionResult Views()
        {
            List<Comment> comm = com.Comments.OrderBy(x => x.Date).ToList();
            return View(comm);
        }
    }
}