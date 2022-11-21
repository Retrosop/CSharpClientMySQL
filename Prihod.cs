using myWpf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWpf
{
    public class Prihod
    {
        [Key]
        [MaxLength(11)]
        public int IdPrihod { get; set; }

        [Required]
        [MaxLength(11)]
        public int PostavId { get; set; }
        public Postav Postav { get; set; }

        [Required]
       // [Column("IdTovar")]
        [MaxLength(11)]
        public int TovarId { get; set; }
        public Tovar Tovar { get; set; }

        [Required]
        [Column(TypeName = "INT(4)")]
        public int Kolvo { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DatPrih { get; set; }
    }
}


