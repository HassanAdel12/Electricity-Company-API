using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricityCompany.Core.Model.FTA;

namespace ElectricityCompany.Core.Model.STA
{
    public class Cutting_Down_B
    {

        [Key]
        public int Cutting_Down_B_Incident_ID { get; set; }

        public string Cutting_Down_Cable_Name { get; set; }


        [ForeignKey("Problem_Type")]
        public int Problem_Type_Key { get; set; }

        public virtual Problem_Type Problem_Type { get; set; }

        public DateOnly? CreateDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public bool IsPlanned { get; set; }

        public bool IsGlobal { get; set; }

        public DateOnly? PlannedStartDTS { get; set; }

        public DateOnly? PlannedEndDTS { get; set; }

        public bool IsActive { get; set; }

        public string? CreatedUser { get; set; }

        public string? UpdatedUser { get; set; }


        public virtual Cutting_Down_Detail? Cutting_Down_Detail { get; set; }

        public virtual Cutting_Down_Header? Cutting_Down_Header { get; set; }

        public virtual Cutting_Down_Ignored? Cutting_Down_Ignored { get; set; }


    }
}
