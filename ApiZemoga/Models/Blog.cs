using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiZemoga.Models
{
    public class Blog
    {
        public int id { get; set; }
        public string authorName { get; set; }
        public string tittle { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
        public DateTime approvedDate { get; set; }
        public string approveBy { get; set; }

    }
}
