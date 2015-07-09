using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasDISC.Models
{
    public class Noticia
    {
        [Key] //Primary Key
        public int NoticiaId { get; set; }

        [Required] //Requerido
        [StringLength(50)] //Largo del atributo titulo, no es necesario pero la BD es feliz cuando se le define
        [Column("titulo")] //Column -> Cual es el nombre que va a tener en la tabla esa columna
        [Display(Name = "Titulo de la noticia")]
        public string Titulo { get; set; }

        [Required]
        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Contenido de la noticia")]
        public string Contenido { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:HH:MM:ss yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Publicacion")]
        public DateTime Publicacion { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string Imagen { get; set; }

        [Display(Name = "Autor")]
        public int AutorId { get; set; }

        public virtual Autor Autor { get; set; }

    }
}
