using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InMemoryCommentRepository
    {
        private readonly List<Comment> _comments = new();

        public InMemoryCommentRepository()
        {
            Comment.CreateComment(1, "This is awesome", 3);
            Comment.CreateComment(2, "I will make this tonight", 5);
            Comment.CreateComment(3, "My kids love this dessert", 1);
            Comment.CreateComment(2, "Such a good recipe", 10);
        }

        public void CreateComment(Comment comment)
        {
            comment.CommentId = _comments.Count + 1;
            _comments.Add(comment);
        }

        public Comment GetComment(int id)
        {
            return _comments.FirstOrDefault(c => c.CommentId == id);
        }

        public IEnumerable<Comment> GetComments()
        {
            return _comments;
        }
    }
}
