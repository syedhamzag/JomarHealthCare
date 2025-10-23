using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class IncidentReportingMap : IEntityTypeConfiguration<IncidentReporting>
    {
        public void Configure(EntityTypeBuilder<IncidentReporting> builder)
        {
            builder.ToTable("tbl_IncidentReporting");
            builder.HasKey(k => k.IncidentReportingId);

            #region Properties
            builder.Property(p => p.IncidentReportingId)
                .HasColumnName("IncidentReportingId")
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

            builder.Property(p => p.IncidentTypeId)
               .HasColumnName("IncidentTypeId")
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
            #endregion

            #region Relationship
            // builder.HasOne(p => p.Client)
            //      .WithMany(p => p.IncidentReporting)
            //      .HasForeignKey(p => p.CompanyId)
            //      .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
