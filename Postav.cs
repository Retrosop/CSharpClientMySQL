using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWpf
{
    public class Postav
    {
        [Key]
        [MaxLength(11)]
        public int IdPostav { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string Name { get; set; }
        
        [Required]
        [Column(TypeName = "VARCHAR(15)")]
        public string Telef { get; set; }

        [Required]
        [MaxLength(11)]
        public int UlicaId { get; set; }
        public Ulica Ulica { get; set; }

        [Required]
        [MaxLength(11)]
        public int GorodId { get; set; }
        public Gorod Gorod { get; set; }

        public ICollection<Prihod> Prihod { get; set; }
    }





//)

}
