using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasDISC.Models
{
    public class Autor
    {
        public int holi { get; set; }
        [Key] 
        public int AutorId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public virtual List<Noticia> Noticias { get; set; }
    }
}
