﻿using DataAccesLayer.Concrete;
using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinnesLayer.Concrete
{
    public class AboutManager
    {
        Repository<About> repoabout = new Repository<About>();

        public List<About> GetAll()
        {
            return repoabout.List();
        }
        public int UpdateAboutBM(About p)
        {
            About about = repoabout.Find(x => x.AboutId == p.AboutId);
            about.AboutContent1 = p.AboutContent1;
            about.AboutContent2 = p.AboutContent2;
            about.AboutImage1 = p.AboutImage1;
            about.AboutImage2 = p.AboutImage2;
            about.AboutId = p.AboutId;
           
            return repoabout.Update(about);
        }
    }
}
