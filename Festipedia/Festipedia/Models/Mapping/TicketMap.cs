using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Festipedia.Models.Mapping
{
    public class TicketMap : EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            // Primary Key
            this.HasKey(t => new { t.fest_id, t.gebr_id });

            // Properties
            this.Property(t => t.fest_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gebr_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Tickets");
            this.Property(t => t.fest_id).HasColumnName("fest_id");
            this.Property(t => t.gebr_id).HasColumnName("gebr_id");
            this.Property(t => t.typ_id).HasColumnName("typ_id");
            this.Property(t => t.ticket_datum).HasColumnName("ticket_datum");

            // Relationships
            this.HasRequired(t => t.Festival)
                .WithMany(t => t.Tickets)
                .HasForeignKey(d => d.fest_id);
            this.HasRequired(t => t.GeregistreerdeGebruiker)
                .WithMany(t => t.Tickets)
                .HasForeignKey(d => d.gebr_id);
            this.HasRequired(t => t.Tickettype)
                .WithMany(t => t.Tickets)
                .HasForeignKey(d => d.typ_id);

        }
    }
}
