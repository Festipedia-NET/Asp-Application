using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class BandMap : EntityTypeConfiguration<Band>
    {
        public BandMap()
        {
            // Primary Key
            this.HasKey(t => t.band_id);

            // Properties
            this.Property(t => t.band_naam)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.band_soortMuziek)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.band_url)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Bands");
            this.Property(t => t.band_id).HasColumnName("band_id");
            this.Property(t => t.band_naam).HasColumnName("band_naam");
            this.Property(t => t.band_soortMuziek).HasColumnName("band_soortMuziek");
            this.Property(t => t.band_url).HasColumnName("band_url");
        }
    }
}
