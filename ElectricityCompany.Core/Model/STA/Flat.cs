using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Flat
    {
        [Key]
        public int Flat_Key { get; set; }

        [ForeignKey("Building")]
        public int Building_Key { get; set; }

        public virtual Building Building { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }


    }
}
