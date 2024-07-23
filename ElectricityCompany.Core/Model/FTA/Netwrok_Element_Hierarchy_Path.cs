using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.FTA
{
    public class Netwrok_Element_Hierarchy_Path
    {

        [Key]
        public int Network_Element_Hierarchy_Path_Key { get; set; }

        public string Netwrok_Element_Hierarchy_Path_Name { get; set; }

        public string Abbreviation { get; set; }

        public virtual ICollection<Netwrok_Element_Type> Netwrok_Element_Types { get; set; }



    }
}
