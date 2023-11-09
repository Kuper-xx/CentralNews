using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace CentralNews.Models
{
    public class Noticia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_noticia { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string autor { get; set; }
        //[Display(Name = "Fecha inscripción")]
        public DateTime fecha { get; set; }
        public string fuente { get; set; }
        [EnumDataType(typeof(TipoCategoria))]
        public TipoCategoria id_categoria { get; set; }
    }
}
