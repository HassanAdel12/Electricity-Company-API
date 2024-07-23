using ElectricityCompany.Core.Model.FTA;
using ElectricityCompany.Core.Model.STA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.FTA
{
    public class Cutting_Down_IgnoredDTO
    {

        public int Cutting_Down_Incident_ID { get; set; }

        public DateOnly? ActualCreatetDate { get; set; }

        public DateOnly? SynchCreateDate { get; set; }

        public string? Cabel_Name { get; set; }

        public string? Cabin_Name { get; set; }

        public string? CreatedUser { get; set; }

        public int? Cutting_Down_A_Incident_ID { get; set; }

        public int? Cutting_Down_B_Incident_ID { get; set; }


    }
}
