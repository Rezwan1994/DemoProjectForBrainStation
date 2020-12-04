using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity
{
    public class ModelClasses
    {
        
    }

    public class UserPostModel
    {
        public Post post { get; set; }
        public List<Comment> commentList { get; set; }

    }

    public class UserPostFilter
    {
        public int? UnitPerPage { get; set; }
        public int? PageNumber { get; set; }
        public string Order { get; set; }
        public string SearchText { get; set; }
 
    }
    public class PostModel
    {
        public List<Post> PostList { get; set; }
        public int TotalCount { get; set; }
    }
}
