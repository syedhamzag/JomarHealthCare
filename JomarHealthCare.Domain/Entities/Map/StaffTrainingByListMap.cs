using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffTrainingByListMap : IEntityTypeConfiguration<StaffTrainingByList>
    {
        public void Configure(EntityTypeBuilder<StaffTrainingByList> builder)
        {
            builder.ToTable("tbl_StaffTrainingByList");
            builder.HasKey(k => k.StaffTrainingId);

            #region Properties
            builder.Property(p => p.StaffTrainingId)
                .HasColumnName("StaffTrainingId");

            builder.Property(p => p.StaffPersonalInfoId)
               .HasColumnName("StaffPersonalInfoId")
               .HasMaxLength(38);

            builder.Property(p => p.Training)
              .HasColumnName("Training")
              .HasMaxLength(255);

            builder.Property(p => p.Certificate)
             .HasColumnName("Certificate")
             .HasMaxLength(125);

            builder.Property(p => p.Location)
             .HasColumnName("Location")
             .HasMaxLength(255);

            builder.Property(p => p.Trainer)
             .HasColumnName("Trainer")
             .HasMaxLength(125);

            builder.Property(p => p.StartDate)
             .HasColumnName("StartDate")
             .HasMaxLength(25);

            builder.Property(p => p.ExpiredDate)
             .HasColumnName("ExpiredDate")
             .HasMaxLength(25)
             .IsRequired(false);

            builder.Property(p => p.TrainingType)
             .HasColumnName("TrainingType")
             .HasMaxLength(50);

            builder.Property(p => p.CertificateAttachment)
             .HasColumnName("CertificateAttachment")
             .IsRequired(false);
            #endregion

            #region Relationship
            builder.HasOne<StaffPersonalInfo>(p => p.Staff)
                .WithMany(p => p.TrainingByList)
                .HasForeignKey(p => p.StaffPersonalInfoId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
