using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLA.Model.Base
{
  /// <summary>
  ///   Базовый дата-объект
  /// </summary>
  [DebuggerDisplay("Id={Id}")]
  public abstract class DataObject
  {

    /// <summary>
    ///   Идентификатор
    /// </summary>
    //[Display(Name = @"Идентификатор")]
    //[RequisiteMetadata(ShowInList = false, ShowInDetails = false)]
    //[Key]
    public Guid Id { get; set; }


    //[Index]
    //[Display(Name = @"Дата изменения", Order = int.MaxValue - 10)]
    //[RequisiteMetadata(ShowInDetails = false, ShowInList = false)]
    //[Editable(false)]
    public virtual DateTime DateModified { get; set; } = DateTime.Now;


    protected DataObject()
    {
      Id = Guid.NewGuid();
    }

    public override string ToString()
    {
      return Id.ToString();
    }
  }
}
