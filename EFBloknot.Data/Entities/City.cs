using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBloknot.Data.Entities
{
    public class City
    {
        public City()
        {
            this.Records = new List<Record>();
        }

        public int ID { get; set; }

        public string Name { get; set; } = "";

        public List<Record> Records { get; set; }
    }
}
