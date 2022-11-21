using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace myWpf
{
    public class Tovar
    {
        [Key]
        [MaxLength(11)]
        public int IdTovar { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string Edizm { get; set; }
        [Required]
        [MaxLength(4)]
        public int Cena { get; set; }

        public ICollection<Prihod> Prihod { get; set; }


        public override string ToString()
        {
            return "" + this.IdTovar;
        }
    }

   
}
