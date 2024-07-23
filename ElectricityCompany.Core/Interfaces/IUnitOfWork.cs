using ElectricityCompany.Core.Model.FTA;
using ElectricityCompany.Core.Model.STA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ElectricityCompany.Core.Interfaces
{
    public interface IUnitOfWork
    {



        //STA


        IGenericRepository<Block> Blocks { get; }

        IGenericRepository<Building> Buildings { get; }

        IGenericRepository<Cabin> Cabins { get; }

        IGenericRepository<Cable> Cables { get; }

        IGenericRepository<City> Cities { get; }

        IGenericRepository<Cutting_Down_A> Cutting_Down_As { get; }

        IGenericRepository<Cutting_Down_B> Cutting_Down_Bs { get; }

        IGenericRepository<Flat> Flats { get; }

        IGenericRepository<Governrate> Governrates { get; }

        IGenericRepository<Problem_Type> Problem_Types { get; }

        IGenericRepository<Sector> Sectors { get; }

        IGenericRepository<Station> Stations { get; }

        IGenericRepository<Subscription> Subscriptions { get; }

        IGenericRepository<Tower> Towers { get; }

        IGenericRepository<Zone> Zones { get; }



        //FTA

        IGenericRepository<Core.Model.FTA.Channel> Channels { get; }

        IGenericRepository<Cutting_Down_Detail> Cutting_Down_Details { get; }

        IGenericRepository<Cutting_Down_Header> Cutting_Down_Headers { get; }

        IGenericRepository<Cutting_Down_Ignored> Cutting_Down_Ignoreds { get; }

        IGenericRepository<Network_Element> Network_Elements { get; }

        IGenericRepository<Netwrok_Element_Hierarchy_Path> Netwrok_Element_Hierarchy_Paths { get; }

        IGenericRepository<Netwrok_Element_Type> Netwrok_Element_Types { get; }



        int Complete();
    }
}
