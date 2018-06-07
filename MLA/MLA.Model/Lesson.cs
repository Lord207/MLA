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

    /// <summary>
    /// Наименование занятий
    /// </summary>
    public LessonName LessonName { get; set; }

    /// <summary>
    /// Учебная группа (например "7-10 лет" или "мастера")
    /// </summary>
    public LearningGroup Group { get; set; }

    /// <summary>
    /// Кабинет
    /// </summary>
    public Room Room { get; set; }

    /// <summary>
    /// Дата занятий
    /// </summary>
    public DateTime Date { get; set; }
    
    /// <summary>
    /// Время занятий (из справочника)
    /// </summary>
    public LessonTime LessonTime { get; set; }

    /// <summary>
    /// Преподяватель
    /// </summary>
    public Teacher Teacher { get; set; }

    /// <summary>
    /// Количество мест на уроке
    /// </summary>
    public int Capacity { get; set; }

    /// <summary>
    /// Комментарий
    /// </summary>
    public string Comment { get; set; }

  }
}
