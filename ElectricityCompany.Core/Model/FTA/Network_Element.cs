using ElectricityCompany.Core.Model.STA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.FTA
{
    public class Network_Element
    {

        [Key]
        public int Network_Element_Key { get; set; }

        public string Network_Element_Name { get; set; }


        [ForeignKey("Netwrok_Element_Type")]
        public int Nework_Element_Type_key { get; set; }

        public virtual Netwrok_Element_Type Netwrok_Element_Type { get; set; }


        [ForeignKey("Parent_Network_Element")]
        public int? Parent_Network_Element_Key { get; set; }

        public virtual Network_Element? Parent_Network_Element { get; set; }

        public virtual ICollection<Cutting_Down_Detail> Cutting_Down_Details { get; set; }

    }
}
