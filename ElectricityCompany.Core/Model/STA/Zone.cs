using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Zone
    {
        [Key]
        public int Zone_Key { get; set; }

        public string Zone_Name { get; set; }

        [ForeignKey("Sector")]
        public int Sector_Key { get; set; }

        public virtual Sector Sector { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
