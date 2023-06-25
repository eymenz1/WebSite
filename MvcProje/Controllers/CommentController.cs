using BussinnesLayer.Concrete;
using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager cm = new CommentManager();
        public PartialViewResult Comment_List(int id)
        {
            var commentlist = cm.CommentByBlog(id);
           
            return PartialView(commentlist);
        }
        [HttpGet]
        public PartialViewResult LeaveComment(int id) 
        {
            ViewBag.id = id;
            return PartialView();   
        }
        [HttpPost]
        public PartialViewResult LeaveComment(Comment c)
        {
            c.CommentStatus = true;
            cm.CommentAdd(c);
            return PartialView();
        }
        public ActionResult AdminCommentListTrue()
        {
            var commentlist = cm.CommentByStatusTrue();
            return View(commentlist);
        }
        public ActionResult AdminCommentListFalse()
        {
            var commentlist = cm.CommentByStatusFalse();
            return View(commentlist);
        }
        public ActionResult StatusChangeToFalse(int id)
        {
            cm.ChangeCommentStatusToFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }
        public ActionResult StatusChangeToTrue(int id)
        {
            cm.ChangeCommentStatusToTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }
    }
}