using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientMgtVisitMap : IEntityTypeConfiguration<ClientMgtVisit>
    {
        public void Configure(EntityTypeBuilder<ClientMgtVisit> builder)
        {
            builder.ToTable("tbl_Client_MgtVisit");
            builder.HasKey(k => k.VisitId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Observation)
               .HasColumnName("Observation")
               .HasMaxLength(2024);

            builder.Property(p => p.EvidenceOfActionTaken)
             .HasColumnName("EvidenceOfActionTaken")
             .HasMaxLength(2024);

            builder.Property(p => p.Remarks)
               .HasColumnName("Remarks")
               .HasMaxLength(2024);

            builder.Property(p => p.ImprovementExpect)
             .HasColumnName("ImprovementExpect")
             .HasMaxLength(2024);

            builder.Property(p => p.ActionRequired)
             .HasColumnName("ActionRequired")
             .HasMaxLength(2024);

            builder.Property(p => p.ActionsTakenByMPCC)
             .HasColumnName("ActionsTakenByMPCC")
             .HasMaxLength(2024);

            builder.Property(p => p.RotCause)
             .HasColumnName("RotCause")
             .HasMaxLength(2024);

            builder.Property(p => p.LessonLearntAndShared)
             .HasColumnName("LessonLearntAndShared")
             .HasMaxLength(2024);

            builder.Property(p => p.URL)
             .HasColumnName("URL")
             .HasMaxLength(1024);

            builder.Property(p => p.Attachment)
             .HasColumnName("Attachment")
             .HasMaxLength(1024);
            #endregion

            #region Relationship
            //builder.HasOne(p => p.Client)
            //   .WithMany(p => p.ClientMgtVisit)
            //   .HasForeignKey(p => p.CompanyId)
            //   .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<VisitStaffName>(p => p.StaffName)
            //    .WithOne(p => p.Visit)
            //    .HasForeignKey(p => p.VisitId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<VisitOfficerToAct>(p => p.OfficerToAct)
            //    .WithOne(p => p.Visit)
            //    .HasForeignKey(p => p.VisitId)
            //    .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
