using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MeetingAgendaMap : IEntityTypeConfiguration<MeetingAgenda>
    {
        public void Configure(EntityTypeBuilder<MeetingAgenda> builder)
        {
            builder.ToTable("tbl_MeetingAgenda");
            builder.HasKey(k => k.MeetingAgendaId);

            #region Properties
            builder.Property(p => p.MeetingAgendaId)
               .HasColumnName("MeetingAgendaId")
               .IsRequired();

            builder.Property(p => p.Agenda)
              .HasColumnName("Agenda")
              .IsRequired();

            builder.Property(p => p.MeetingLogId)
             .HasColumnName("MeetingLogId")
             .IsRequired();

            #endregion
        }
    }
}
