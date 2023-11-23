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
        // Estas propiedades se usan para mostrar en el formulario.
        [NotMapped] // Indica que no se mapeará a la base de datos.
        public string? NombreAutor { get; set; }
        [NotMapped]
        public string? NombreNoticia { get; set; }
       
        public int id_usuario { get; set; }
        public int id_noticia { get; set; }
        public string comment { get; set; }
        public DateTime Fecha { get; set; }
        // Relaciones
        [ForeignKey("id_usuario")]
        public Usuario? Usuario { get; set; }

        [ForeignKey("id_noticia")]
        public Noticia? Noticia { get; set; }

    }
}
