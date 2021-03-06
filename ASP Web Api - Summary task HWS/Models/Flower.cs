using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Web_Api___Summary_task_HWS.Models
{
    public class Flower
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name{ get; set; }
        public string Description { get; set; }
        public string Colors { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
    }
}
