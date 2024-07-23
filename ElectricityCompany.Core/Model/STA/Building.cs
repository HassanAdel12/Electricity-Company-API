using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Building
    {
        [Key]
        public int Building_Key { get; set; }

        public string Building_Name { get; set; }

        [ForeignKey("Block")]
        public int Block_Key { get; set; }

        public virtual Block Block { get; set; }

        public virtual ICollection<Flat> Flats { get; set; }


    }
}
