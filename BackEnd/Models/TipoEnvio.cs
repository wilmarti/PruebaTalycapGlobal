using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BackEnd.Models
{
    public class TipoEnvio
    {

        [Key]
        public int IdTipoEnvio { get; set; }


        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string DescripcionTipoEnvio { get; set; }



    }
}
