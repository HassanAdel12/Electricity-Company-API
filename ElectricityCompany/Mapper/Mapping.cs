using AutoMapper;
using static System.Collections.Specialized.BitVector32;
using System.Reflection.Emit;
using ElectricityCompany.Core.Model.STA;
using ElectricityCompany.Core.DTO.STA;
using ElectricityCompany.Core.Model.FTA;
using ElectricityCompany.Core.DTO.FTA;

namespace ElectricityCompany.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {

         
            CreateMap<Cutting_Down_A, Cutting_Down_ADTO>().ReverseMap();

            CreateMap<Cutting_Down_B, Cutting_Down_BDTO>().ReverseMap();

            CreateMap<Problem_Type, Problem_TypeDTO>().ReverseMap();

            CreateMap<Channel, ChannelDTO>().ReverseMap();

            CreateMap<Cutting_Down_Detail, Cutting_Down_DetailDTO>().ReverseMap();

            CreateMap<Cutting_Down_Header, Cutting_Down_HeaderDTO>().ReverseMap();

            CreateMap<Cutting_Down_Ignored, Cutting_Down_IgnoredDTO>().ReverseMap();

            CreateMap<Network_Element, Network_ElementDTO>().ReverseMap();





        }
    }
}
