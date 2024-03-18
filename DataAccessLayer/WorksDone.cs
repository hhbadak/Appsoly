using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class WorksDone
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public String Customer { get; set; }
        public int ServiceID { get; set; }
        public string Service { get; set; }
        public decimal TotalFee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Team1Fee { get; set; }
        public decimal Team2Fee { get; set; }
        public int Team1ID { get; set; }
        public string Team1 { get; set; }
        public int Team2ID { get; set; }
        public string Team2 { get; set; }
        public int SectionID { get; set; }
        public decimal MyFee { get; set; }
    }
}
