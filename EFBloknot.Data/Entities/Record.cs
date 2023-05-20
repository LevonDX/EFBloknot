using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBloknot.Data.Entities
{
    public class Record
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = "";

        public string? Description { get; set; }

        public string Surname { get; set; } = "";

        [Required]
        public int? Level { get; set; }

        [ForeignKey("City")]
        public int? CityID { get; set; }

        public City City { get; set; } // Navigation property

        public override string ToString()
        {
            return Name;
        }
    }
}
