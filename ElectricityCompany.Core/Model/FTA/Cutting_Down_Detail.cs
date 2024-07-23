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
    public class Cutting_Down_Detail
    {

        [Key]
        public int Cutting_Down_Detail_Key { get; set; }


        [ForeignKey("Cutting_Down_Header")]
        public int Cutting_Down_Key { get; set; }

        public virtual Cutting_Down_Header Cutting_Down_Header { get; set; }



        [ForeignKey("Network_Element")]
        public int Network_Element_Key { get; set; }

        public virtual Network_Element Network_Element { get; set; }

        public DateOnly? ActualCreatetDate { get; set; }

        public DateOnly? ActualEndDate { get; set; }

        public int ImpactedCustomers { get; set; }


        [ForeignKey("Cutting_Down_A")]
        public int? Cutting_Down_A_Incident_ID { get; set; }

        public virtual Cutting_Down_A? Cutting_Down_A { get; set; }


        [ForeignKey("Cutting_Down_B")]
        public int? Cutting_Down_B_Incident_ID { get; set; }

        public virtual Cutting_Down_B? Cutting_Down_B { get; set; }


    }
}
