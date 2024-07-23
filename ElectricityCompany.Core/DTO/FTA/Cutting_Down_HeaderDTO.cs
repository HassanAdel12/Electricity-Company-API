using ElectricityCompany.Core.Model.FTA;
using ElectricityCompany.Core.Model.STA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.FTA
{
    public class Cutting_Down_HeaderDTO
    {

        public int Cutting_Down_Key { get; set; }

        public int Cutting_Down_Incident_ID { get; set; }

        public int Channel_Key { get; set; }

        public int Cutting_Down_Problem_Type_Key { get; set; }

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

        public int? Cutting_Down_A_Incident_ID { get; set; }

        public int? Cutting_Down_B_Incident_ID { get; set; }



    }
}
