using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Debts
    {
        public int ID { get; set; }
        public int PayeeID { get; set; }
        public string Payee { get; set; }
        public decimal TotalDebt { get; set; }
        public decimal MonthlyPayment { get; set; }
        public Boolean Statu { get; set; }
    }
}
