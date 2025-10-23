using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CommunicationLogMap : IEntityTypeConfiguration<CommunicationLog>
    {
        public void Configure(EntityTypeBuilder<CommunicationLog> builder)
        {
            builder.ToTable("tbl_CommunicationLog");
            builder.HasKey(k => k.CommunicationLogId);

            #region Properties
            builder.Property(p => p.CommunicationLogId)
               .HasColumnName("CommunicationLogId")
               .IsRequired();

            builder.Property(p => p.MeetingTitle)
               .HasColumnName("MeetingTitle")
               .HasMaxLength(150);

            builder.Property(p => p.Date)
               .HasColumnName("Date")
               .IsRequired();

            builder.Property(p => p.Time)
               .HasColumnName("Time")
               .IsRequired();

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .IsRequired();

            builder.Property(p => p.MinuteTaker)
               .HasColumnName("MinuteTaker")
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(p => p.ClinicalPresentation)
               .HasColumnName("ClinicalPresentation")
               .HasMaxLength(1024);

            builder.Property(p => p.Discussion)
               .HasColumnName("Discussion")
               .HasMaxLength(1024);

            builder.Property(p => p.Plan)
               .HasColumnName("Plan")
               .HasMaxLength(1024);

            builder.Property(p => p.ActionItems)
                .HasColumnName("ActionItems")
                .HasMaxLength(1024);

            builder.Property(p => p.CaseNo)
                .HasColumnName("CaseNo")
                .HasMaxLength(50);

            builder.Property(p => p.CompanyId)
               .HasColumnName("CompanyId")
               .HasMaxLength(38);

            builder.Property(p => p.AttendeeName)
               .HasColumnName("AttendeeName")
               .HasMaxLength(1024);

            builder.Property(p => p.ApologiesName)
               .HasColumnName("ApologiesName")
               .HasMaxLength(1024);
            #endregion

            #region Relationship
            builder.HasMany<CommunicationLogAttendees>(p => p.Attendee)
                .WithOne(p => p.CommunicationLog)
                .HasForeignKey(p => p.CommunicationLogId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}
