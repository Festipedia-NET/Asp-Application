using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class BandsPerFestivalMap : EntityTypeConfiguration<BandsPerFestival>
    {
        public BandsPerFestivalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.fest_id, t.band_id, t.datum });

            // Properties
            this.Property(t => t.fest_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.band_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BandsPerFestival");
            this.Property(t => t.fest_id).HasColumnName("fest_id");
            this.Property(t => t.band_id).HasColumnName("band_id");
            this.Property(t => t.pod_id).HasColumnName("pod_id");
            this.Property(t => t.datum).HasColumnName("datum");
            this.Property(t => t.uur).HasColumnName("uur");

            // Relationships
            this.HasRequired(t => t.Band)
                .WithMany(t => t.BandsPerFestivals)
                .HasForeignKey(d => d.band_id);
            this.HasRequired(t => t.Festival)
                .WithMany(t => t.BandsPerFestivals)
                .HasForeignKey(d => d.fest_id);
            this.HasRequired(t => t.Podia)
                .WithMany(t => t.BandsPerFestivals)
                .HasForeignKey(d => d.pod_id);

        }
    }
}
