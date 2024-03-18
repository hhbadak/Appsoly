using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PlanCalendar
    {
        public int ID { get; set; }
        public string Planned { get; set; }
        public DateTime PlanDate { get; set; }
        public int StatuID { get; set; }
        public string Statu { get; set; }
    }
}
