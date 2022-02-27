using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneDoktor.Entities
{
    public class Doktor
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Adi { get; set; }

        [StringLength(100)]
        public string Soyadi { get; set; }

        [StringLength(100)]
        public string Uzmanligi { get; set; }

    }
}
