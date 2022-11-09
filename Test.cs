using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWpf
{
    public class Test
    {
        [Key]
        [MaxLength(11)]
        public int IdTest { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string Name { get; set; }
    }
}
