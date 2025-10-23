using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class UntowardsMap : IEntityTypeConfiguration<Untowards>
    {
        public void Configure(EntityTypeBuilder<Untowards> builder)
        {
            builder.ToTable("tbl_Untowards");
            builder.HasKey(k => k.UntowardsId);

            #region Properties
            builder.Property(p => p.UntowardsId)
                .HasColumnName("UntowardsId")
                .IsRequired();

            builder.Property(p => p.TicketNumber)
              .HasColumnName("TicketNumber")
              .HasMaxLength(50)
              .IsRequired();


            builder.Property(p => p.Subject)
             .HasColumnName("Subject")
             .HasMaxLength(225)
             .IsRequired();


            builder.Property(p => p.PersonReporting)
             .HasColumnName("PersonReporting")
             .HasMaxLength(128);

            builder.Property(p => p.PersonReportingTelephone)
             .HasColumnName("PersonReportingTelephone")
             .HasMaxLength(20);

            builder.Property(p => p.PersonReportingEmail)
             .HasColumnName("PersonReportingEmail")
             .HasMaxLength(256);

            builder.Property(p => p.Details)
             .HasColumnName("Details");

            builder.Property(p => p.ActionStatus)
             .HasColumnName("ActionStatus")
             .HasMaxLength(128);

            builder.Property(p => p.Priority)
             .HasColumnName("Priority")
             .HasMaxLength(7);

            builder.Property(p => p.ActionTaken)
             .HasColumnName("ActionTaken");

            builder.Property(p => p.ActionRequired)
             .HasColumnName("ActionRequired");

            builder.Property(p => p.CreatedBy)
             .HasColumnName("CreatedBy")
             .HasMaxLength(450);

            builder.Property(p => p.IncidentType)
             .HasColumnName("IncidentType")
             .HasMaxLength(128);
            #endregion


        }
    }
}
