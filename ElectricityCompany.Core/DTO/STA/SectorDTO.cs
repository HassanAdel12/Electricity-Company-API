using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.STA
{
    public class SectorDTO
    {
        public int Sector_Key { get; set; }

        public string Sector_Name { get; set; }

        public int Governrate_Key { get; set; }



    }
}
