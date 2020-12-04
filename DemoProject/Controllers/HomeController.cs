using Demo.Entity;
using Demo.Facade;
using Demo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoProject.Controllers
{
    public class HomeController : Controller
    {
        Demo.Facade.PostFacade postFacade = null;
        Demo.Facade.CommentFacade commentFacade = null;
        Demo.Facade.UserFacade userFacade = null;
        public HomeController()
        {
            DataContext Context = DataContext.getInstance();
            postFacade = new Demo.Facade.PostFacade(Context);
            commentFacade = new Demo.Facade.CommentFacade(Context);
            userFacade = new Demo.Facade.UserFacade(Context);
        }
        public ActionResult LoadPostList()
        {
            return View();
        }
        public ActionResult GetAllPosts(UserPostFilter filter)
        {
            if (filter.PageNumber == 0)
            {
                filter.PageNumber = 1;
            }
            filter.UnitPerPage = 2;

            if (filter.PageNumber == null || filter.PageNumber == 0)
            {
                filter.PageNumber = 1;
            }

            List<Demo.Entity.Post> postList = new List<Demo.Entity.Post>();
            PostModel postmodel = new PostModel();
            postmodel = postFacade.GetAllPost(filter);
            if(postmodel != null && postmodel.PostList != null && postmodel.PostList.Count > 0)
            {
                

            }
            else
            {
                User user1 = new User()
                {
                    UserId = Guid.NewGuid(),
                    UserName = "Rezwan",
                    Email = "rezwan.aiub10@gmail.com",
                    Phone = "01750425444",
                    Role = "Admin"
                };
                userFacade.Insert(user1);
                User user2 = new User()
                {
                    UserId = Guid.NewGuid(),
                    UserName = "Sadik",
                    Email = "sadik.aiub10@gmail.com",
                    Phone = "01740476666",
                    Role = "Admin"
                };
                userFacade.Insert(user2);
                User user3 = new User()
                {
                    UserId = Guid.NewGuid(),
                    UserName = "Sabah",
                    Email = "sabah.aiub10@gmail.com",
                    Phone = "01754546735",
                    Role = "Admin"
                };
                userFacade.Insert(user3);
                Post post1 = new Post()
                {
                    PostId = Guid.NewGuid(),
                    PostStatement = "Post 1",
                    PostDate = DateTime.UtcNow,
                    TotalComment = 0,
                    UserId = user1.UserId
                };
                postFacade.Insert(post1);
                Post post2 = new Post()
                {
                    PostId = Guid.NewGuid(),
                    PostStatement = "Post 2",
                    PostDate = DateTime.UtcNow,
                    TotalComment = 0,
                    UserId = user2.UserId
                };
                postFacade.Insert(post2);
                Post post3 = new Post()
                {
                    PostId = Guid.NewGuid(),
                    PostStatement = "Post 3",
                    PostDate = DateTime.UtcNow,
                    TotalComment = 0,
                    UserId = user3.UserId
                };
                postFacade.Insert(post3);

                Comment comment1 = new Comment()
                {
                    CommentId = Guid.NewGuid(),
                    CommentStatement = "Comment 1",
                    CommentDate = DateTime.UtcNow,
                    Like = 268,
                    Dislike = 128,
                    PostId = post1.PostId,
                    UserId = user1.UserId
                };
                commentFacade.Insert(comment1);

                Comment comment2 = new Comment()
                {
                    CommentId = Guid.NewGuid(),
                    CommentStatement = "Comment 2",
                    CommentDate = DateTime.UtcNow,
                    Like = 268,
                    Dislike = 128,
                    PostId = post1.PostId,
                    UserId = user2.UserId
                };
                commentFacade.Insert(comment2);

                Comment comment3 = new Comment()
                {
                    CommentId = Guid.NewGuid(),
                    CommentStatement = "Comment 3",
                    CommentDate = DateTime.UtcNow,
                    Like = 268,
                    Dislike = 128,
                    PostId = post1.PostId,
                    UserId = user3.UserId
                };
                commentFacade.Insert(comment3);

                Comment comment4 = new Comment()
                {
                    CommentId = Guid.NewGuid(),
                    CommentStatement = "Comment 4",
                    CommentDate = DateTime.UtcNow,
                    Like = 268,
                    Dislike = 128,
                    PostId = post2.PostId,
                    UserId = user1.UserId
                };
                commentFacade.Insert(comment4);

                Comment comment5 = new Comment()
                {
                    CommentId = Guid.NewGuid(),
                    CommentStatement = "Comment 5",
                    CommentDate = DateTime.UtcNow,
                    Like = 268,
                    Dislike = 128,
                    PostId = post2.PostId,
                    UserId = user2.UserId
                };
                commentFacade.Insert(comment5);
                Comment comment6 = new Comment()
                {
                    CommentId = Guid.NewGuid(),
                    CommentStatement = "Comment 6",
                    CommentDate = DateTime.UtcNow,
                    Like = 268,
                    Dislike = 128,
                    PostId = post2.PostId,
                    UserId = user3.UserId
                };
                commentFacade.Insert(comment6);
                Comment comment7 = new Comment()
                {
                    CommentId = Guid.NewGuid(),
                    CommentStatement = "Comment 7",
                    CommentDate = DateTime.UtcNow,
                    Like = 268,
                    Dislike = 128,
                    PostId = post2.PostId,
                    UserId = user3.UserId
                };
                commentFacade.Insert(comment7);
                Comment comment8 = new Comment()
                {
                    CommentId = Guid.NewGuid(),
                    CommentStatement = "Comment 8",
                    CommentDate = DateTime.UtcNow,
                    Like = 268,
                    Dislike = 128,
                    PostId = post3.PostId,
                    UserId = user1.UserId
                };
                commentFacade.Insert(comment8);
                Comment comment9 = new Comment()
                {
                    CommentId = Guid.NewGuid(),
                    CommentStatement = "Comment 9",
                    CommentDate = DateTime.UtcNow,
                    Like = 268,
                    Dislike = 128,
                    PostId = post3.PostId,
                    UserId = user2.UserId
                };
                commentFacade.Insert(comment9);
                Comment comment10 = new Comment()
                {
                    CommentId = Guid.NewGuid(),
                    CommentStatement = "Comment 10",
                    CommentDate = DateTime.UtcNow,
                    Like = 268,
                    Dislike = 128,
                    PostId = post3.PostId,
                    UserId = user3.UserId
                };
                commentFacade.Insert(comment10);
            }
            postmodel = postFacade.GetAllPost(filter);
            List<UserPostModel> userPostList = new List<UserPostModel>();
            List<Comment> commentList = new List<Comment>();
  
            foreach(var item in postmodel.PostList)
            {
                commentList = commentFacade.GetAllCommentsByPostId(item.PostId);
                if(commentList != null && commentList.Count > 0)
                {
                    item.TotalComment = commentList.Count;
                    postFacade.Update(item);
                }
      
                UserPostModel model = new UserPostModel()
                {
                    post = item,
                    commentList = commentList,
                };
                userPostList.Add(model);
            }

            ViewBag.OutOfNumber = postmodel.TotalCount;
            if ((int)ViewBag.OutOfNumber == 0)
            {
                ViewBag.Message = "No Content Available !";
            }
            if (@ViewBag.OutOfNumber == 0)
            {
                filter.PageNumber = 1;
            }
            ViewBag.PageNumber = filter.PageNumber;

            if ((int)ViewBag.PageNumber * filter.UnitPerPage > (int)ViewBag.OutOfNumber)
            {
                ViewBag.CurrentNumber = (int)ViewBag.OutOfNumber;
            }
            else
            {
                ViewBag.CurrentNumber = (int)ViewBag.PageNumber * filter.UnitPerPage;
            }

            ViewBag.PageCount = Math.Ceiling((double)ViewBag.OutOfNumber / filter.UnitPerPage.Value);
            return View(userPostList);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}