using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.FTA
{
    public class Channel
    {

        [Key]
        public int Channel_Key { get; set; }

        public string Channel_Name { get; set; }

        public virtual ICollection<Cutting_Down_Header> Cutting_Down_Headers { get; set; }




    }
}
