using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffMedRotaMap : IEntityTypeConfiguration<StaffMedRota>
    {
        public void Configure(EntityTypeBuilder<StaffMedRota> builder)
        {
            builder.ToTable("tbl_StaffMedRota");
            builder.HasKey(k => k.StaffRotaId);

            #region Properties

            builder.Property(p => p.StaffRotaId)
                .HasColumnName("StaffRotaId")
                .IsRequired();

            builder.Property(p => p.ReferenceNumber)
             .HasColumnName("ReferenceNumber")
              .HasMaxLength(50);

            builder.Property(p => p.DoseGiven)
             .HasColumnName("DoseGiven")
              .HasMaxLength(50);

            builder.Property(p => p.Time)
             .HasColumnName("Time")
              .HasMaxLength(50);

            builder.Property(p => p.Measurement)
             .HasColumnName("Measurement")
              .HasMaxLength(128);

            builder.Property(p => p.Location)
             .HasColumnName("Location")
              .HasMaxLength(512);

            builder.Property(p => p.Feedback)
             .HasColumnName("Feedback")
              .HasMaxLength(2024);


            builder.Property(p => p.Remark)
               .HasColumnName("Remark")
               .HasMaxLength(2048);

            builder.Property(p => p.ClockInLocation)
               .HasColumnName("ClockInLocation")
               .HasMaxLength(256);

            builder.Property(p => p.ClockOutLocation)
               .HasColumnName("ClockOutLocation")
               .HasMaxLength(256);

            builder.Property(p => p.DosePrescribed)
               .HasColumnName("DosePrescribed")
               .HasMaxLength(2024);

            builder.Property(p => p.StaffCommentsOrConcern)
               .HasColumnName("StaffCommentsOrConcern")
               .HasMaxLength(2024);

            builder.Property(p => p.GivenMedicationNotInChart)
               .HasColumnName("GivenMedicationNotInChart")
               .HasMaxLength(1024);

            builder.Property(p => p.Attachment)
               .HasColumnName("Attachment")
               .HasMaxLength(1024);

            builder.Property(p => p.CompanyId)
                .HasColumnName("CompanyId")
                .HasMaxLength(38);
            #endregion


        }
    }
}
