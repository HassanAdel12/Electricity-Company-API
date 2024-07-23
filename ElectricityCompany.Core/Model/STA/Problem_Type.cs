using ElectricityCompany.Core.Model.FTA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Model.STA
{
    public class Problem_Type
    {

        [Key]
        public int Problem_Type_Key { get; set; }

        public string problem_Type_Name { get; set; }

        public virtual ICollection<Cutting_Down_A> Cutting_Down_As { get; set; }

        public virtual ICollection<Cutting_Down_B> Cutting_Down_Bs { get; set; }

        public virtual ICollection<Cutting_Down_Header> Cutting_Down_Headers { get; set; }
    }
}
