﻿using BussinnesLayer.Concrete;
using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class MailSubscribeController : Controller
    {
        // GET: MailSubscribe
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail p)
        {
            SubscribeMailManager sm=new SubscribeMailManager();
            sm.BLAdd(p);
            return PartialView();  
        }
    }
}