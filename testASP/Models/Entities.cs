//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;

//namespace testASP.Models
//{
//    //public class Entities
//    //{
//    //    public List<string> Names = new List<string>();
//    //    public void Add()
//    //    {
//    //        using (UsersContext db = new UsersContext())
//    //        {
//    //            Groups g1 = new Groups { Name = "Administrator" };
//    //            Groups g2 = new Groups { Name = "Moderator" };
//    //            Groups g3 = new Groups { Name = "Client" };
//    //            db.Group.Add(g1);
//    //            db.Group.Add(g2);
//    //            db.Group.Add(g3);
//    //            db.SaveChanges();

//    //            User usr1 = new User { Name = "Bob", Password = "12345", groups = g1, groupsId=g1.Id };
//    //            User usr2 = new User { Name = "Frank", Password = "pass", groups = g3, groupsId=g3.Id };
//    //            User usr3 = new User { Name = "Martin", Password = "123", groups = g3, groupsId = g3.Id };
//    //            User usr4 = new User { Name = "Jack", Password = "qwerty", groups = g3, groupsId = g3.Id };
//    //            User usr5 = new User { Name = "Paul", Password = "asd", groups = g2, groupsId = g2.Id };
//    //            User usr6 = new User { Name = "Ted", Password = "password", groups = g2, groupsId = g2.Id };
//    //            db.Users.Add(usr1);
//    //            db.Users.Add(usr2);
//    //            db.Users.Add(usr3);
//    //            db.Users.Add(usr4);
//    //            db.Users.Add(usr5);
//    //            db.Users.Add(usr6);
//    //            db.SaveChanges();
//    //            Show();
//    //        }                        
//    //    }
//    //    private static void Show()
//    //    {
//    //        using (UsersContext db = new UsersContext())
//    //        {
//    //            var names = from b in db.Users orderby b.Name select b;
//    //            foreach (var item in names)
//    //            {
//    //                Names.Add(item.Name);
//    //            }
//    //        }
//    //    }
//    //}
//    class myUsersInitializer:DropCreateDatabaseIfModelChanges<UsersContext>
//    {
//        protected override void Seed(UsersContext db)
//        {
//            Groups g1 = new Groups { Name = "Administrator" };
//            Groups g2 = new Groups { Name = "Moderator" };
//            Groups g3 = new Groups { Name = "Client" };
//            db.Group.Add(g1);
//            db.Group.Add(g2);
//            db.Group.Add(g3);

//            User usr1 = new User { Name = "Bob", Password = "12345", groups = g1, groupsId = g1.Id };
//            User usr2 = new User { Name = "Frank", Password = "pass", groups = g3, groupsId = g3.Id };
//            User usr3 = new User { Name = "Martin", Password = "123", groups = g3, groupsId = g3.Id };
//            User usr4 = new User { Name = "Jack", Password = "qwerty", groups = g3, groupsId = g3.Id };
//            User usr5 = new User { Name = "Paul", Password = "asd", groups = g2, groupsId = g2.Id };
//            User usr6 = new User { Name = "Ted", Password = "password", groups = g2, groupsId = g2.Id };
//            db.Users.Add(usr1);
//            db.Users.Add(usr2);
//            db.Users.Add(usr3);
//            db.Users.Add(usr4);
//            db.Users.Add(usr5);
//            db.Users.Add(usr6);
//            db.SaveChanges();
//        }
//        public void Add()
//        {
//            using (UsersContext db = new UsersContext())
//            {
//                Seed(db);
//            }
//        }
//    }
//    public class Groups
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }

//        public ICollection<User> Users { get; set; }
//        public Groups()
//        {
//            Users = new List<User>();
//        }


//    }
//    public class User
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Password { get; set; }

//        public int? groupsId { get; set; }
//        public Groups groups { get; set; }
//    }
//    class UsersContext: DbContext
//    {
//        static UsersContext()
//        {
//            Database.SetInitializer<UsersContext>(new myUsersInitializer());
//        }
//        public UsersContext() : base("UsersContext") { }

//        public DbSet<User> Users { get; set; }
//        public DbSet<Groups> Group { get; set; }
//    }
//}