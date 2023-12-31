﻿using DataAccesLayer.Concrete;
using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinnesLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repocomment = new Repository<Comment>();

        public List<Comment> CommentList()
        {
            return repocomment.List();
        }
        public List<Comment> CommentByBlog(int id)
        {
            return repocomment.List(x => x.BlogId == id);
        }
        public List<Comment> CommentByStatusTrue()
        {
            return repocomment.List(x => x.CommentStatus == true);
        }
        public List<Comment> CommentByStatusFalse()
        {
            return repocomment.List(x => x.CommentStatus == false);
        }
        public int CommentAdd(Comment c)
        {
            if (c.CommentText.Length <= 4 || c.CommentText.Length >= 300 || c.Username == "" || c.Mail == "" || c.Username.Length <= 4)
            {
                return -1;
            }
            return repocomment.Insert(c);
        }
        public int ChangeCommentStatusToFalse(int id)
        {
            Comment comment = repocomment.Find(x => x.CommentId == id);
            comment.CommentStatus = false;
            return repocomment.Update(comment);
        }
        public int ChangeCommentStatusToTrue(int id)
        {
            Comment comment = repocomment.Find(x => x.CommentId == id);
            comment.CommentStatus = true;
            return repocomment.Update(comment);
        }

    }
}
