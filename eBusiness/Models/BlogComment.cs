using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBusiness.Models
{
    public class BlogComment
    {
        public int Id { get; set; }
        [Required]
        public string User { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [StringLength(maximumLength:150)]
        public string Desc { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
