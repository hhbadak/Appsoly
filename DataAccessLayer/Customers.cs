using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Customers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string CompanyPosition { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
    }
}
