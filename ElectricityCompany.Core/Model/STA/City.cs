using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class City
    {
        [Key]
        public int City_Key { get; set; }

        public string City_Name { get; set; }

        [ForeignKey("Zone")]
        public int Zone_Key { get; set; }

        public virtual Zone Zone { get; set; }

        public virtual ICollection<Station> Stations { get; set; }
    }
}
