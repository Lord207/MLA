using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLA.Model.Base;
using MLA.Model.Classifier;

namespace MLA.Model
{
  public class Lesson : DataObject
  {

    public LessonName LessonName { get; set; }

    public LearningGroup Group { get; set; }

    public Room Room { get; set; }

    public DateTime Date { get; set; }
    public LessonTime LessonTime { get; set; }

    public Teacher Teacher { get; set; }

    public int Capacity { get; set; }



    public string Comment { get; set; }

  }
}
