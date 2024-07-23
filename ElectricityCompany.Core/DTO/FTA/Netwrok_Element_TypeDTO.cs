﻿using ElectricityCompany.Core.Model.FTA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.DTO.FTA
{
    public class Netwrok_Element_TypeDTO
    {

        public int Nework_Element_Type_key { get; set; }

        public string Network_Element_Type_Name { get; set; }

        public int Network_Element_Hierarchy_Path_Key { get; set; }

        public int? Parent_Network_Element_Type_key { get; set; }


    }
}
