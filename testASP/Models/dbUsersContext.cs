using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Entities;
using Domain;
using System.Data.Entity;
using System.Configuration;

namespace testASP.Models
{
    public class dbUsersContext
    {
        private myDbContext context;

        public dbUsersContext()
        {
            context = new myDbContext(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        }

        public IEnumerable<User> getUsers()
        {
            return context.Users;
        }

        public User getUserById(int id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}