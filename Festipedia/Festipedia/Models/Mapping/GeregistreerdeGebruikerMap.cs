using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class GeregistreerdeGebruikerMap : EntityTypeConfiguration<GeregistreerdeGebruiker>
    {
        public GeregistreerdeGebruikerMap()
        {
            // Primary Key
            this.HasKey(t => t.gebr_id);

            // Properties
            this.Property(t => t.gebr_naam)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.gebr_adres)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeregistreerdeGebruikers");
            this.Property(t => t.gebr_id).HasColumnName("gebr_id");
            this.Property(t => t.gebr_naam).HasColumnName("gebr_naam");
            this.Property(t => t.gebr_adres).HasColumnName("gebr_adres");
            this.Property(t => t.gebr_gebDat).HasColumnName("gebr_gebDat");
        }
    }
}
