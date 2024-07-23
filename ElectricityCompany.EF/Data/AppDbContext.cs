using ElectricityCompany.Core.Model.FTA;
using ElectricityCompany.Core.Model.JWT;
using ElectricityCompany.Core.Model.STA;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ElectricityCompany.EF.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {

        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }

        //STA

        public virtual DbSet<Block> Blocks { get; set; }

        public virtual DbSet<Building> Buildings { get; set; }

        public virtual DbSet<Cabin> Cabins { get; set; }

        public virtual DbSet<Cable> Cables { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Cutting_Down_A> Cutting_Down_As { get; set; }

        public virtual DbSet<Cutting_Down_B> Cutting_Down_Bs { get; set; }

        public virtual DbSet<Flat> Flats { get; set; }

        public virtual DbSet<Governrate> Governrates { get; set; }

        public virtual DbSet<Problem_Type> Problem_Types { get; set; }

        public virtual DbSet<Sector> Sectors { get; set; }

        public virtual DbSet<Station> Stations { get; set; }

        public virtual DbSet<Subscription> Subscriptions { get; set; }

        public virtual DbSet<Tower> Towers { get; set; }

        public virtual DbSet<Zone> Zones { get; set; }



        //FTA

        public virtual DbSet<Core.Model.FTA.Channel> Channels { get; set; }

        public virtual DbSet<Cutting_Down_Detail> Cutting_Down_Details { get; set; }

        public virtual DbSet<Cutting_Down_Header> Cutting_Down_Headers { get; set; }

        public virtual DbSet<Cutting_Down_Ignored> Cutting_Down_Ignoreds { get; set; }

        public virtual DbSet<Network_Element> Network_Elements { get; set; }

        public virtual DbSet<Netwrok_Element_Hierarchy_Path> Netwrok_Element_Hierarchy_Paths { get; set; }

        public virtual DbSet<Netwrok_Element_Type> Netwrok_Element_Types { get; set; }


    }
}
