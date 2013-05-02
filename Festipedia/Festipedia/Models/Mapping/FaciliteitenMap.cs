using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class FaciliteitenMap : EntityTypeConfiguration<Faciliteiten>
    {
        public FaciliteitenMap()
        {
            // Primary Key
            this.HasKey(t => t.fac_id);

            // Properties
            this.Property(t => t.fac_omschr)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Faciliteiten");
            this.Property(t => t.fac_id).HasColumnName("fac_id");
            this.Property(t => t.fac_omschr).HasColumnName("fac_omschr");
            this.Property(t => t.fac_eenhprijs).HasColumnName("fac_eenhprijs");
        }
    }
}
