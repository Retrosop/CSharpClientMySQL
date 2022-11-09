using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myWpf
{
    public class Goods
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Cena { get; set; }

    }   
}
