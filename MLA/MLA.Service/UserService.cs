using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using MLA.DAL;
using Microsoft.AspNet.Identity.EntityFramework;
using MLA.Model;


namespace MLA.Service
{
  public static class UserService
  {
    private static readonly ApplicationDbContext _contex;


    static UserService()
    {
      _contex = new ApplicationDbContext();
    }


    public static List<IdentityRole> GetRoles()
    {
      var roles = _contex.Roles.ToListAsync();
      return roles.Result;
    }


    public static List<User> GetUsersByRole(IdentityRole role)
    {
      var users = _contex.Users.Where(u => u.Roles.Any(r => r.RoleId == role.Id));
      return users.ToListAsync().Result;
    }



  }
}