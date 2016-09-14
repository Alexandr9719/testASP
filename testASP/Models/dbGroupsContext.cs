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
    public class dbGroupsContext
    {
        private myDbContext context;

        public dbGroupsContext()
        {
            context = new myDbContext(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        }

        public IEnumerable<Groups> getGroups()
        {
            return context.Groups;
        }

        public Groups getGroupsById(int id)
        {
            return context.Groups.FirstOrDefault(x => x.Id == id);
        }
    }
}