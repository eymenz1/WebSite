using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context: DbContext

        //context sınıfı entity layer üzerine oluşturmuş olduğumuz sınıfları veritabanına yansıtmak için gerekli olan köprü
    {
        // Entitiy layer concrete ekleyince <about> kısmındaki hata gitti
        // About sınıf Abouts ise sınıfın karşılığı
        public DbSet <About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SubscribeMail> SubscribeMails { get; set;}


    }
}
