using ElectricityCompany.Core.Model.FTA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.FTA
{
    public class Network_ElementDTO
    {

        public int Network_Element_Key { get; set; }

        public string Network_Element_Name { get; set; }

        public int Nework_Element_Type_key { get; set; }

        public int? Parent_Network_Element_Key { get; set; }


    }
}
