using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Festipedia.Models.Mapping;

namespace Festipedia.Models
{
    public partial class groep15_festivalsContext : DbContext
    {
        static groep15_festivalsContext()
        {
            Database.SetInitializer<groep15_festivalsContext>(null);
        }

        public groep15_festivalsContext()
            : base("Name=groep15_festivalsContext")
        {
        }

        public DbSet<Band> Bands { get; set; }
        public DbSet<BandsPerFestival> BandsPerFestivals { get; set; }
        public DbSet<Camping> Campings { get; set; }
        public DbSet<Faciliteiten> Faciliteitens { get; set; }
        public DbSet<FacPerCamp> FacPerCamps { get; set; }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<GeregistreerdeGebruiker> GeregistreerdeGebruikers { get; set; }
        public DbSet<Podia> Podias { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Tickettype> Tickettypes { get; set; }
        public DbSet<TickettypesPerFestival> TickettypesPerFestivals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BandMap());
            modelBuilder.Configurations.Add(new BandsPerFestivalMap());
            modelBuilder.Configurations.Add(new CampingMap());
            modelBuilder.Configurations.Add(new FaciliteitenMap());
            modelBuilder.Configurations.Add(new FacPerCampMap());
            modelBuilder.Configurations.Add(new FestivalMap());
            modelBuilder.Configurations.Add(new GeregistreerdeGebruikerMap());
            modelBuilder.Configurations.Add(new PodiaMap());
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new TickettypeMap());
            modelBuilder.Configurations.Add(new TickettypesPerFestivalMap());
        }
    }
}
