using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Governrate
    {
        [Key]
        public int Governrate_Key { get; set; }

        public string Governrate_Name { get; set; }

        public virtual ICollection<Sector> Sectors { get; set; }

    }
}
