using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Entities
{
    public class TimeFrame
    {
        public DateTime DateFrom { get; }
        public DateTime DateTo { get; }

        public TimeFrame(DateTime dateFrom, DateTime dateTo)
        {
            if (dateFrom < dateTo)
            {
                this.DateFrom = dateFrom;
                this.DateTo = dateTo;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
