using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Incomes
    {
        public int ID { get; set; }
        public int IncomeSourceID { get; set; }
        public string IncomeSource { get; set; }
        public decimal IncomingFee { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
