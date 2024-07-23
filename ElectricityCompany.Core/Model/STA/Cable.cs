using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Cable
    {
        [Key]
        public int Cable_Key { get; set; }

        public string Cable_Name { get; set; }

        [ForeignKey("Cabin")]
        public int Cabin_Key { get; set; }

        public virtual Cabin Cabin { get; set; }

        public virtual ICollection<Block> Blocks { get; set; }
    }
}
