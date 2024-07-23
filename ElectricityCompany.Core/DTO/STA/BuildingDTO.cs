using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.STA
{
    public class BuildingDTO
    {

        public int Building_Key { get; set; }

        public string Building_Name { get; set; }

        public int Block_Key { get; set; }



    }
}
