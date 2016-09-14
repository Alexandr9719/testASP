using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data.Entity;

namespace Domain
{
    public class myDbContext: DbContext
    {
        public myDbContext(string stringConnections)
        {
            Database.Connection.ConnectionString = stringConnections;   
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Groups> Groups { get; set; }

        public class ContextInitializer:CreateDatabaseIfNotExists<myDbContext>
        {
            protected override void Seed(myDbContext context)
            {
                //base.Seed(context);
                IList<User> users = new List<User>();
                users.Add(new User { Name = "Jack", groupName = "Administrator" });
                users.Add(new User { Name = "Bob", groupName = "Client" });
                users.Add(new User { Name = "Sarah", groupName = "Editor" });
                users.Add(new User { Name = "Clay", groupName = "Client" });
                users.Add(new User { Name = "Frank", groupName = "Client" });
                users.Add(new User { Name = "Martin", groupName = "Editor" });

                foreach (User item in users)
                    context.Users.Add(item);

                IList<Groups> groups = new List<Groups>();

                groups.Add(new Groups { Name = "Administrator" });
                groups.Add(new Groups { Name = "Client" });
                groups.Add(new Groups { Name = "Editor" });

                foreach (Groups group in groups)
                    context.Groups.Add(group);

                base.Seed(context);

            }
        }
    }
}
