using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class FacPerCampMap : EntityTypeConfiguration<FacPerCamp>
    {
        public FacPerCampMap()
        {
            // Primary Key
            this.HasKey(t => new { t.camp_id, t.fac_id });

            // Properties
            this.Property(t => t.camp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fac_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FacPerCamp");
            this.Property(t => t.camp_id).HasColumnName("camp_id");
            this.Property(t => t.fac_id).HasColumnName("fac_id");
            this.Property(t => t.aantal).HasColumnName("aantal");

            // Relationships
            this.HasRequired(t => t.Camping)
                .WithMany(t => t.FacPerCamps)
                .HasForeignKey(d => d.camp_id);
            this.HasRequired(t => t.Faciliteiten)
                .WithMany(t => t.FacPerCamps)
                .HasForeignKey(d => d.fac_id);

        }
    }
}
