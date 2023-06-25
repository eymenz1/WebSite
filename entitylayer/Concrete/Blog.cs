using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        [StringLength(100)]
        public string BlogTitle { get; set; }
        [StringLength(100)]
        public string BlogImage { get; set;}

        public DateTime BlogDate { get; set;}

        public string BlogContent { get; set;}
        public int BlogRating { get; set; }

        //Blog ve kategori kısmını ilişkilendirdik.

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        //Yazar ve blog içinde aynısı yapıldı.
        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }

        public ICollection <Comment> Comments { get; set; }
    }
}
