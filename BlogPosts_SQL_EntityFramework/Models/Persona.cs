using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlogPosts_SQL_EntityFramework.Models
{
    [Table("Personas", Schema = "dbo")]

    public class Persona
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; } = "";

        [MaxLength(50)]
        public int? NumTelefono { get; set; }

        [MaxLength(100)]
        public string? Mail { get; set; }
    }
}
