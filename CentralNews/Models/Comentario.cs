using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CentralNews.Models
{
    public class Comentario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_comentario { get; set; }
        public int id_usuario { get; set; }
        public int id_noticia { get; set; }
        public string comment { get; set; }
        public DateTime Fecha { get; set; } 
    }
}
