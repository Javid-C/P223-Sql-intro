using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBusiness.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Admin { get; set; }
        public string Quote { get; set; }
        public DateTime Date { get; set; }
        public List<BlogComment> BlogComments{ get; set; }

    }
}
