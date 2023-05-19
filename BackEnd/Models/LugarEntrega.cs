using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class LugarEntrega
    {

        [Key]
        public int IdLugarEntrega { get; set; }

        [Required]
        [Column(TypeName = "Varchar(20)")]
        public string Lugar { get; set; }

        [Required]
        [Column(TypeName = "Varchar(150)")]
        public string Descripcion { get; set; }

        [Required]
        [Column(TypeName = "Varchar(150)")]
        public string Direccion { get; set; }

        [Required]
        [Column(TypeName = "Varchar(150)")]
        public string Telefono { get; set; }

    }
}
