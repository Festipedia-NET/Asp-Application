using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class TickettypeMap : EntityTypeConfiguration<Tickettype>
    {
        public TickettypeMap()
        {
            // Primary Key
            this.HasKey(t => t.typ_id);

            // Properties
            this.Property(t => t.typ_omschr)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Tickettypes");
            this.Property(t => t.typ_id).HasColumnName("typ_id");
            this.Property(t => t.typ_omschr).HasColumnName("typ_omschr");
            this.Property(t => t.typ_prijs).HasColumnName("typ_prijs");
        }
    }
}
