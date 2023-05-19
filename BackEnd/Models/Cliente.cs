using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BackEnd.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [Column(TypeName = "Varchar(5)")]
        public string TipoIdentificacion { get; set; }

        [Required]
        [Column(TypeName = "Varchar(30)")]
        public string IdentificacionCliente { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string NombreCliente { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string Direccion { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Telefono { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string Email { get; set; }

    }
}
