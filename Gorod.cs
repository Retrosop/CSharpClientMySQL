using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWpf
{
    public class Gorod
    {
        [Key]
        [MaxLength(11)]
        public int IdGorod { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string Name { get; set; }

        public ICollection<Postav> PostavG { get; set; }
    }
}
