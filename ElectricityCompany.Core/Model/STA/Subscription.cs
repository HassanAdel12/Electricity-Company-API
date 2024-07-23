using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Subscription
    {
        [Key]
        public int Subscription_Key { get; set; }

        [ForeignKey("Flat")]
        public int Flat_Key { get; set; }

        public virtual Flat Flat { get; set; }




    }
}
