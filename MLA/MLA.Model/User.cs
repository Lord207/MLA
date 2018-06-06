using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLA.Model.Base;

namespace MLA.Model
{
  public class User:DataObject
  {

    public string Login { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public DateTime BirthDay { get; set; }



  }
}
