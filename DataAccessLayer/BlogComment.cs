using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BlogComment
    {
        public int ID { get; set; }
        public int BlogID { get; set; }
        public string Blog { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string Comment { get; set; }
        public int Count { get; set; }
    }
}
