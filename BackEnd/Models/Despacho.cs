using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Despacho
    {

        [Key]
        public int IdDespacho { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string FechaRegistro { get; set; }

        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string FechaEntrega { get; set; }

        [Required]
        [Column(TypeName = "Varchar(20)")]
        public string Precio { get; set; }

        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string NumeroTransporte { get; set; }

        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string NumeroGuia { get; set; }

        [Required]
        public int IdTipoEnvio { get; set; }

        [Required]
        public int IdLugarEntrega { get; set; }


    }
}
