using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class FestivalMap : EntityTypeConfiguration<Festival>
    {
        public FestivalMap()
        {
            // Primary Key
            this.HasKey(t => t.fest_id);

            // Properties
            this.Property(t => t.fest_naam)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.fest_locatie)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Festivals");
            this.Property(t => t.fest_id).HasColumnName("fest_id");
            this.Property(t => t.fest_naam).HasColumnName("fest_naam");
            this.Property(t => t.fest_locatie).HasColumnName("fest_locatie");
            this.Property(t => t.fest_datum).HasColumnName("fest_datum");
            this.Property(t => t.fest_duur).HasColumnName("fest_duur");
        }
    }
}
