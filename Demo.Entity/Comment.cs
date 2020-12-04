using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity
{
    public class Comment : Entity
    {
        public Guid CommentId { get; set; }
        public string CommentStatement { get; set; }
        public DateTime CommentDate { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        [NotMapped]
        public string UserName { get; set; }

    }
    [NotMapped]
    public class CommentVM : Comment
    {

    }
}
