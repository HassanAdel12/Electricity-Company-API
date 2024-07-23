using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.STA
{
    public class StationDTO
    {
        public int Station_Key { get; set; }

        public string Station_Name { get; set; }

        public int City_Key { get; set; }

       
    }
}
