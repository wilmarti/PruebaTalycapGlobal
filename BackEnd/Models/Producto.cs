using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BackEnd.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string DescripcionProducto { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string TipoProducto { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Precio { get; set; }



    }
}
