using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Writers;
using System.Data.Common;
using System.Reflection.PortableExecutable;

namespace WebAPI.models
{
    public class UserContact:DbContext
    {

      public UserContact(DbContextOptions options):base(options)
        { 
         
        }

        public DbSet<User> Users { get; set; }

    }
}
