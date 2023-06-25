using BussinnesLayer.Concrete;
using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager();
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public ActionResult SendMassage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMassage(Contact p)
        {
            cm.BLContactAdd(p);
            return View();
        }
        public ActionResult SendBox()
        {
            var messagelist = cm.GetAll();
            return View(messagelist);
        }
        public ActionResult MessageDetails(int id)
        {
            Contact contact=cm.GetContactDetails(id);
            return View(contact);
        }
    }
}
