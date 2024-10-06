using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string ImgThumb { get; set; }
        public string Image1 { get; set; }
        public string Contents1 { get; set; }
        public string Contents2 { get; set; }
        public string Image2 { get; set; }
        public string ImportantInformation { get; set; }
        public string Content2Continued { get; set; }
        public string Weld { get; set; }
        public int ServiceID { get; set; }
        public string Service { get; set; }
        public int TeamID { get; set; }
        public string Team { get; set; }
        public DateTime Date { get; set; }
        public string Datestr { get; set; }
        public int CommentCount { get; set; } // Yorum sayısı için property

    }
}
