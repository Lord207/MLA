﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using MLA.Model;

namespace MLA.DAL
{


  public class ApplicationDbContext : IdentityDbContext<User>
  {
    public ApplicationDbContext()
      : base("DBConnection", throwIfV1Schema: false)
    {
    }

    public static ApplicationDbContext Create()
    {
      return new ApplicationDbContext();
    }

  }

}
