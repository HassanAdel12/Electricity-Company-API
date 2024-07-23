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
    public class Cutting_Down_Ignored
    {

        [Key]
        public int Cutting_Down_Incident_ID { get; set; }

        public DateOnly? ActualCreatetDate { get; set; }

        public DateOnly? SynchCreateDate { get; set; }

        public string? Cabel_Name { get; set; }

        public string? Cabin_Name { get; set; }

        public string? CreatedUser { get; set; }


        public virtual ICollection<Cutting_Down_Header> Cutting_Down_Headers { get; set; }


        [ForeignKey("Cutting_Down_A")]
        public int? Cutting_Down_A_Incident_ID { get; set; }

        public virtual Cutting_Down_A? Cutting_Down_A { get; set; }


        [ForeignKey("Cutting_Down_B")]
        public int? Cutting_Down_B_Incident_ID { get; set; }

        public virtual Cutting_Down_B? Cutting_Down_B { get; set; }


    }
}
