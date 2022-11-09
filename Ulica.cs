using myWpf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWpf
{
    public class Ulica
    {
        [Key]
        [MaxLength(11)]
        public int IdUlica { get; set; }

        [Required]
        [Column(TypeName ="VARCHAR(255)")]
        public string Name { get; set; }
    }
}
