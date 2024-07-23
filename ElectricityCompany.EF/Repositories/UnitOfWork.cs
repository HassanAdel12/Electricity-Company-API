using ElectricityCompany.Core.Interfaces;
using ElectricityCompany.Core.Model.FTA;
using ElectricityCompany.Core.Model.STA;
using ElectricityCompany.EF.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Reflection.Metadata.BlobBuilder;

namespace ElectricityCompany.EF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext Context;

        public UnitOfWork(AppDbContext _Context)
        {
            Context = _Context;

            //STA

            Blocks = new GenericRepository<Block>(Context);

            Buildings = new GenericRepository<Building>(Context);
            Cabins = new GenericRepository<Cabin>(Context);

            Cables = new GenericRepository<Cable>(Context);

            Cities = new GenericRepository<City>(Context);

            Cutting_Down_As = new GenericRepository<Cutting_Down_A>(Context);

            Cutting_Down_Bs = new GenericRepository<Cutting_Down_B>(Context);

            Flats = new GenericRepository<Flat>(Context);

            Governrates = new GenericRepository<Governrate>(Context);

            Problem_Types = new GenericRepository<Problem_Type>(Context);

            Sectors = new GenericRepository<Sector>(Context);

            Stations = new GenericRepository<Station>(Context);

            Subscriptions = new GenericRepository<Subscription>(Context);

            Towers = new GenericRepository<Tower>(Context);

            Zones = new GenericRepository<Zone>(Context);


            //FTA


            Channels = new GenericRepository<Channel>(Context);

            Cutting_Down_Details = new GenericRepository<Cutting_Down_Detail>(Context);

            Cutting_Down_Headers = new GenericRepository<Cutting_Down_Header>(Context);

            Cutting_Down_Ignoreds = new GenericRepository<Cutting_Down_Ignored>(Context);

            Network_Elements = new GenericRepository<Network_Element>(Context);

            Netwrok_Element_Hierarchy_Paths = new GenericRepository<Netwrok_Element_Hierarchy_Path>(Context);

            Netwrok_Element_Types = new GenericRepository<Netwrok_Element_Type>(Context);

        }

        //STA


        public IGenericRepository<Block> Blocks { get; private set; }

        public IGenericRepository<Building> Buildings { get; private set; }

        public IGenericRepository<Cabin> Cabins { get; private set; }

        public IGenericRepository<Cable> Cables { get; private set; }

        public IGenericRepository<City> Cities { get; private set; }

        public IGenericRepository<Cutting_Down_A> Cutting_Down_As { get; private set; }

        public IGenericRepository<Cutting_Down_B> Cutting_Down_Bs { get; private set; }

        public IGenericRepository<Flat> Flats { get; private set; }

        public IGenericRepository<Governrate> Governrates { get; private set; }

        public IGenericRepository<Problem_Type> Problem_Types { get; private set; }

        public IGenericRepository<Sector> Sectors { get; private set; }

        public IGenericRepository<Station> Stations { get; private set; }

        public IGenericRepository<Subscription> Subscriptions { get; private set; }

        public IGenericRepository<Tower> Towers { get; private set; }

        public IGenericRepository<Zone> Zones { get; private set; }



        //FTA

        public IGenericRepository<Channel> Channels { get; private set; }

        public IGenericRepository<Cutting_Down_Detail> Cutting_Down_Details { get; private set; }

        public IGenericRepository<Cutting_Down_Header> Cutting_Down_Headers { get; private set; }

        public IGenericRepository<Cutting_Down_Ignored> Cutting_Down_Ignoreds { get; private set; }

        public IGenericRepository<Network_Element> Network_Elements { get; private set; }

        public IGenericRepository<Netwrok_Element_Hierarchy_Path> Netwrok_Element_Hierarchy_Paths { get; private set; }

        public IGenericRepository<Netwrok_Element_Type> Netwrok_Element_Types { get; private set; }

        
        
        public int Complete()
        {
            return Context.SaveChanges();
        }

    }
}
