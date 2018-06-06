using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLA.Model;

namespace MLA.DAL
{
  public class UserContext : DbContext
  {

    public UserContext()
      : base("DbConnection")
    {
      //
    }


    public DbSet<User> Users { get; set; }




  }
}
