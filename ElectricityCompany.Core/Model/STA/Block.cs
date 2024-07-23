using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Block
    {
        [Key]
        public int Block_Key { get; set; }

        public string Block_Name { get; set; }

        [ForeignKey("Cable")]
        public int Cable_Key { get; set; }

        public virtual Cable Cable { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
    }
}
