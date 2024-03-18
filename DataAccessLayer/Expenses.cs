using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Expenses
    {
        public int ID { get; set; }
        public int ExpenseSourceID { get; set; }
        public string ExpenseSource { get; set; }
        public decimal OutGoingFee { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
