using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLA.Model.Base;

namespace MLA.Model
{
  public class Abonement : DataObject
  {
    public string Number { get; set; }

    public User User { get; set; }

    public DateTime CreateDate { get; set; }

  }
}