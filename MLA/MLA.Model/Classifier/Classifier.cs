using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLA.Model.Base;

namespace MLA.Model.Classifier
{

  /// <summary>
  /// Базовый класс Справочника
  /// </summary>
  public class Classifier : DataObject
  {


    [DisplayName("Наименование")]
    public virtual string Name { get; set; }

    [DisplayName("Коментарий")]
    public virtual string Comment { get;set; }

    [DisplayName("Запись удалена")]
    public virtual bool Deleted { get; set; }

    [DisplayName("Запись только для чтения")]
    public virtual bool ReadOnly { get; set; }


  }
}
