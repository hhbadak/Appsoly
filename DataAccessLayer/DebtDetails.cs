using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DebtDetails
    {
        public int ID { get; set; }
        public int PayeeID { get; set; }
        public string Payee { get; set; }
        public int DebtID { get; set; }
        public string Debt { get; set; }
        public decimal MonthlyPayment { get; set; }
        public DateTime InstallmentDate { get; set; }
        public bool Status { get; set; }
        public string StatusStr { get; set; }
    }
}
