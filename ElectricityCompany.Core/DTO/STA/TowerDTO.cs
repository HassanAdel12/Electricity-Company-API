using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.STA
{
    public class TowerDTO
    {

        public int Tower_Key { get; set; }

        public string Tower_Name { get; set; }

        public int Station_Key { get; set; }


    }
}
