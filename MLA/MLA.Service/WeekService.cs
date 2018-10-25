using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLA.Model;
using MLA.Model.Base;

namespace MLA.Service
{
    public static class WeekService
    {


        public static Week BuildWeek(DateTime date)
        {
            var week = new Week(date);


            return week;
        }




    }
}
