using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffIncidentReportingMap : IEntityTypeConfiguration<StaffIncidentReporting>
    {
        public void Configure(EntityTypeBuilder<StaffIncidentReporting> builder)
        {
            builder.ToTable("tbl_StaffIncidentReporting");
            builder.HasKey(k => k.StaffIncidentReportingId);

            #region Properties
            builder.Property(p => p.StaffIncidentReportingId)
                .HasColumnName("StaffIncidentReportingId")
                .IsRequired();

            builder.Property(p => p.ReportingStaffId)
               .HasColumnName("ReportingStaffId")
               .IsRequired(false);

            builder.Property(p => p.CompanyId)
               .HasColumnName("ClientId")
               .IsRequired();

            builder.Property(p => p.StaffInvolvedId)
               .HasColumnName("StaffInvolvedId")
               .IsRequired();

            builder.Property(p => p.IncidentDetails)
               .HasColumnName("IncidentDetails")
               .IsRequired();

            builder.Property(p => p.ActionTaken)
               .HasColumnName("ActionTaken")
               .HasMaxLength(250)
               .IsRequired(false);

            builder.Property(p => p.Witness)
               .HasColumnName("Witness")
               .IsRequired(false);

            builder.Property(p => p.Attachment)
               .HasColumnName("Attachment")
               .IsRequired(false);

            builder.Property(p => p.LoggedById)
              .HasColumnName("LoggedById")
              .HasMaxLength(225)
              .IsRequired();

            builder.Property(p => p.LoggedDate)
              .HasColumnName("LoggedDate")
              .IsRequired();
            builder.Property(p => p.IncidentType)
             .HasColumnName("IncidentType")
             .HasMaxLength(128);

            builder.Property(p => p.Status)
             .HasColumnName("Status")
             .HasMaxLength(128);
            #endregion
        }
    }
}
