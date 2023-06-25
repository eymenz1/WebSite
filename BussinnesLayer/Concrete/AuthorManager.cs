using DataAccesLayer.Concrete;
using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinnesLayer.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repoauthor = new Repository<Author>();
        //Tüm yazar listesini getirme yeri
        public List<Author> GetAll()
        {
            return repoauthor.List();
        }
        // Yeni Yazar ekleme yeri.
        public int AddAuthorBL(Author p)
        {
            //Parametreden gönderilen değerlerinin kontrolü
            if(p.AuthorName=="" || p.AboutShort=="" || p.AuthorTitle == "")
            {
                return -1;
            }
            return repoauthor.Insert(p);
        }
        //yazarın id değerine göre edit sayfasına taşıma
        public Author FindAuthor(int id)
        {
            return repoauthor.Find(x => x.AuthorID == id);
        }
        public int EditAuthor(Author p)
        {
            Author author=repoauthor.Find(x=>x.AuthorID == p.AuthorID);
            author.AboutShort= p.AboutShort;
            author.AuthorName= p.AuthorName;
            author.AuthorImage= p.AuthorImage;
            author.AuthorAbout= p.AuthorAbout;
            author.AuthorTitle= p.AuthorTitle;
            author.Mail= p.Mail;
            author.Password= p.Password;
            author.PhoneNumber= p.PhoneNumber;
            return repoauthor.Update(author);
        }
    }
}
