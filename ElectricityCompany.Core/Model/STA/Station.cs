using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Station
    {
        [Key]
        public int Station_Key { get; set; }

        public string Station_Name { get; set; }

        [ForeignKey("City")]
        public int City_Key { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Tower> Towers { get; set; }
    }
}
