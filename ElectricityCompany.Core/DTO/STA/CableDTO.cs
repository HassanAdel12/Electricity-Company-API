using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.STA
{
    public class CableDTO
    {
        public int Cable_Key { get; set; }

        public string Cable_Name { get; set; }

        public int Cabin_Key { get; set; }


    }
}
