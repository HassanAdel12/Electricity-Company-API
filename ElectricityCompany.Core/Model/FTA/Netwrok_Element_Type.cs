using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.FTA
{
    public class Netwrok_Element_Type
    {

        [Key]
        public int Nework_Element_Type_key { get; set; }

        public string Network_Element_Type_Name { get; set; }

        [ForeignKey("Netwrok_Element_Hierarchy_Path")]
        public int Network_Element_Hierarchy_Path_Key { get; set; }

        public virtual Netwrok_Element_Hierarchy_Path Netwrok_Element_Hierarchy_Path { get; set; }


        [ForeignKey("Parent_Network_Element_Type")]
        public int? Parent_Network_Element_Type_key { get; set; }

        public virtual Netwrok_Element_Type? Parent_Network_Element_Type { get; set; }

        public virtual ICollection<Network_Element> Network_Elements { get; set; }


    }
}
