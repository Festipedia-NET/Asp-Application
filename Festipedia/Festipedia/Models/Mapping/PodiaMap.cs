using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class PodiaMap : EntityTypeConfiguration<Podia>
    {
        public PodiaMap()
        {
            // Primary Key
            this.HasKey(t => t.pod_id);

            // Properties
            this.Property(t => t.pod_omschr)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pod_locatie)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Podia");
            this.Property(t => t.pod_id).HasColumnName("pod_id");
            this.Property(t => t.pod_omschr).HasColumnName("pod_omschr");
            this.Property(t => t.pod_locatie).HasColumnName("pod_locatie");
        }
    }
}
