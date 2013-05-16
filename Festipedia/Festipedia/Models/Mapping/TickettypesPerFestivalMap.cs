using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class TickettypesPerFestivalMap : EntityTypeConfiguration<TickettypesPerFestival>
    {
        public TickettypesPerFestivalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.fest_id, t.typ_id });

            // Properties
            this.Property(t => t.fest_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.typ_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TickettypesPerFestival");
            this.Property(t => t.fest_id).HasColumnName("fest_id");
            this.Property(t => t.typ_id).HasColumnName("typ_id");
            this.Property(t => t.aantal).HasColumnName("aantal");

            // Relationships
            this.HasRequired(t => t.Festival)
                .WithMany(t => t.TickettypesPerFestivals)
                .HasForeignKey(d => d.fest_id);
            this.HasRequired(t => t.Tickettype)
                .WithMany(t => t.TickettypesPerFestivals)
                .HasForeignKey(d => d.typ_id);

        }
    }
}
