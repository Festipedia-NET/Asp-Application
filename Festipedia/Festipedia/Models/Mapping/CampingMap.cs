using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class CampingMap : EntityTypeConfiguration<Camping>
    {
        public CampingMap()
        {
            // Primary Key
            this.HasKey(t => t.camp_id);

            // Properties
            this.Property(t => t.camp_adres)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Campings");
            this.Property(t => t.camp_id).HasColumnName("camp_id");
            this.Property(t => t.camp_adres).HasColumnName("camp_adres");
            this.Property(t => t.camp_cap).HasColumnName("camp_cap");

            // Relationships
            this.HasMany(t => t.Festivals)
                .WithMany(t => t.Campings)
                .Map(m =>
                    {
                        m.ToTable("CampingsPerFestival");
                        m.MapLeftKey("camp_id");
                        m.MapRightKey("fest_id");
                    });


        }
    }
}
