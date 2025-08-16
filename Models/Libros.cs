using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFC_CRUD.Models
{
    [Table("LIBROS")]
    public class Libros
    {
        [Key]//Llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Auto Incremental
        [Column("Id_LIBRO")]
        public int id;
        [Required]
        [MaxLength(100)]
        [Column("NOMBRE")]
        public string nombre;

        [Required]
        [MaxLength(100)]
        [Column("AUTOR")]
        public string autor;

        [Required]//No puede ser nulo
        [Column("FECHA_PUBLICACION")]//NO SE USA MAXLENGTH PORQUE ES UN DATETIME
        public DateTime fechaPublicacion;

        [Required]
        [MaxLength(100)]
        [Column("GENERO")]
        public string genero;

        [Required]
        [MaxLength(100)]
        [Column("EDITORIAL")]
        public string editorial;
    }
}
