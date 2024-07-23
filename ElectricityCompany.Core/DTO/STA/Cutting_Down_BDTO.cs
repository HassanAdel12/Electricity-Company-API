using ElectricityCompany.Core.Model.STA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.STA
{
    public class Cutting_Down_BDTO
    {

        public int Cutting_Down_B_Incident_ID { get; set; }

        public string Cutting_Down_Cable_Name { get; set; }

        public int Problem_Type_Key { get; set; }

        public DateOnly? CreateDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public bool IsPlanned { get; set; }

        public bool IsGlobal { get; set; }

        public DateOnly? PlannedStartDTS { get; set; }

        public DateOnly? PlannedEndDTS { get; set; }

        public bool IsActive { get; set; }

        public string? CreatedUser { get; set; }

        public string? UpdatedUser { get; set; }


    }
}
