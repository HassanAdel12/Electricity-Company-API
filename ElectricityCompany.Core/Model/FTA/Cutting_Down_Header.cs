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
    public class Cutting_Down_Header
    {

        [Key]
        public int Cutting_Down_Key { get; set; }


        [ForeignKey("Cutting_Down_Ignored")]
        public int Cutting_Down_Incident_ID { get; set; }

        public virtual Cutting_Down_Ignored Cutting_Down_Ignored { get; set; }




        [ForeignKey("Channel")]
        public int Channel_Key { get; set; }

        public virtual Channel Channel { get; set; }




        [ForeignKey("Problem_Type")]
        public int Cutting_Down_Problem_Type_Key { get; set; }

        public virtual Problem_Type Problem_Type { get; set; }
        

        public DateOnly? ActualCreatetDate { get; set; }

        public DateOnly? SynchCreateDate { get; set; }

        public DateOnly? SynchUpdateDate { get; set; }

        public DateOnly? ActualEndDate { get; set; }

        public bool IsPlanned { get; set; }

        public bool IsGlobal { get; set; }

        public DateOnly? PlannedStartDTS { get; set; }

        public DateOnly? PlannedEndDTS { get; set; }

        public bool IsActive { get; set; }

        public string? CreateSystemUser { get; set; }

        public string? UpdateSystemUser { get; set; }


        public virtual ICollection<Cutting_Down_Detail> Cutting_Down_Details { get; set; }


        [ForeignKey("Cutting_Down_A")]
        public int? Cutting_Down_A_Incident_ID { get; set; }

        public virtual Cutting_Down_A? Cutting_Down_A { get; set; }


        [ForeignKey("Cutting_Down_B")]
        public int? Cutting_Down_B_Incident_ID { get; set; }

        public virtual Cutting_Down_B? Cutting_Down_B { get; set; }


    }
}
