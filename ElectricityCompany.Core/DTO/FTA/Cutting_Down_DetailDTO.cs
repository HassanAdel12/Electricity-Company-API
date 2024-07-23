using ElectricityCompany.Core.Model.FTA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricityCompany.Core.Model.STA;

namespace ElectricityCompany.Core.DTO.FTA
{
    public class Cutting_Down_DetailDTO
    {

        public int Cutting_Down_Detail_Key { get; set; }

        public int Cutting_Down_Key { get; set; }

        public int Network_Element_Key { get; set; }


        public DateOnly? ActualCreatetDate { get; set; }

        public DateOnly? ActualEndDate { get; set; }

        public int ImpactedCustomers { get; set; }

        public int? Cutting_Down_A_Incident_ID { get; set; }

        public int? Cutting_Down_B_Incident_ID { get; set; }


    }
}
