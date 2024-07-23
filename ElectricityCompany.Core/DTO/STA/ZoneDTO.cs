using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.STA
{
    public class ZoneDTO
    {
        public int Zone_Key { get; set; }

        public string Zone_Name { get; set; }

        public int Sector_Key { get; set; }


    }
}
