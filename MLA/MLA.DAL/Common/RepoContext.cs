using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MLA.Model;
using MLA.Model.Classifier;

namespace MLA.DAL.Common
{
  public class RepoContext : DbContext
  {
    public RepoContext()
      : base("DBConnection")
    {
    }


    //public DbSet<LearningGroup> LearningGroups { get; set; }

    //public DbSet<LessonName> LessonNames { get; set; }

    //public DbSet<LessonTime> LessonTimes { get; set; }

    public DbSet<Room> Rooms { get; set; }

    //public DbSet<Teacher> Teachers { get; set; }

  }
}