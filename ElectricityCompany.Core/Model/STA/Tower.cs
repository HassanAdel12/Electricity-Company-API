using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Tower
    {

        [Key]
        public int Tower_Key { get; set; }

        public string Tower_Name { get; set; }

        [ForeignKey("Station")]
        public int Station_Key { get; set; }

        public virtual Station Station { get; set; }

        public virtual ICollection<Cabin> Cabins { get; set; }
    }
}
