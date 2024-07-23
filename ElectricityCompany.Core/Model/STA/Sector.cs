using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Sector
    {
        [Key]
        public int Sector_Key { get; set; }

        public string Sector_Name { get; set; }

        [ForeignKey("Governrate")]
        public int Governrate_Key { get; set; }

        public virtual Governrate Governrate { get; set; }

        public virtual ICollection<Zone> Zones { get; set; }

    }
}
