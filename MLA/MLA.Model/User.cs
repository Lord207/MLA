using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MLA.Model.Base;

namespace MLA.Model
{


  // You can add profile data for the user by adding more properties to your ApplicationUser class,
  // please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

  public class User: IdentityUser
  {
    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
    {
      // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
      var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
      // Add custom user claims here
      return userIdentity;
    }


    //public string Id { get; set; }

    //public string UserName { get; set; }
    
    //public string Email { get; set; }

    public string Phone { get; set; }

    public DateTime BirthDay { get; set; }



  }
}
