using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using DAL.Entities;

namespace DAL.EF
{
    public class ApplicationContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string connectionstring) : base(connectionstring) { }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
    }
}
