using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HospitalEntryMap : IEntityTypeConfiguration<HospitalEntry>
    {
        public void Configure(EntityTypeBuilder<HospitalEntry> builder)
        {
            builder.ToTable("tbl_HospitalEntry");
            builder.HasKey(k => k.HospitalEntryId);

            #region Properties

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Reference)
               .HasColumnName("Reference")
               .HasMaxLength(2048);

            builder.Property(p => p.PurposeofAdmission)
               .HasColumnName("PurposeofAdmission")
               .HasMaxLength(1024);

            builder.Property(p => p.Attachment)
             .HasColumnName("Attachment")
             .HasMaxLength(512);

            builder.Property(p => p.Remark)
               .HasColumnName("Remark")
               .HasMaxLength(2048);

            builder.Property(p => p.StaffSignature)
               .HasColumnName("StaffSignature")
               .HasMaxLength(1024);

            #endregion

            #region Relationship

            // builder.HasOne(p => p.Client)
            //     .WithMany(p => p.HospitalEntry)
            //     .HasForeignKey(p => p.CompanyId)
            //     .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<HospitalEntryPersonToTakeAction>(p => p.PersonToTakeAction)
            //    .WithOne(p => p.HospitalEntry)
            //    .HasForeignKey(p => p.HospitalEntryId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<HospitalEntryStaffInvolved>(p => p.StaffInvolved)
            //    .WithOne(p => p.HospitalEntry)
            //    .HasForeignKey(p => p.HospitalEntryId)
            //    .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
