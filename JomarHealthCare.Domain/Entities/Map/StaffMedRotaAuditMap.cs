using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffMedRotaAuditMap : IEntityTypeConfiguration<StaffMedRotaAudit>
    {
        public void Configure(EntityTypeBuilder<StaffMedRotaAudit> builder)
        {
            builder.ToTable("tbl_StaffMedRotaAudit");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(p => p.AuditRemarks)
             .HasColumnName("AuditRemarks")
              .HasMaxLength(500);

            builder.Property(p => p.ActionRecommendation)
             .HasColumnName("ActionRecommendation")
              .HasMaxLength(500);

            builder.Property(p => p.ContactEstablishedWithGP)
               .HasColumnName("ContactEstablishedWithGP")
               .IsRequired();

            builder.Property(p => p.StateDisuccGP)
               .HasColumnName("StateDisuccGP")
               .HasMaxLength(250);

            builder.Property(p => p.EvidenceOfActionTaken)
               .HasColumnName("EvidenceOfActionTaken")
               .HasMaxLength(500);

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(p => p.NameOfAuditor)
               .HasColumnName("NameOfAuditor")
               .HasMaxLength(250)
               .IsRequired();

            builder.Property(p => p.DateOfAudit)
             .HasColumnName("Date")
             .IsRequired();

            builder.Property(p => p.EmailAuditToStaff)
             .HasColumnName("EmailAuditToStaff")
             .IsRequired();

            builder.Property(p => p.ConcernWithStaff)
             .HasColumnName("DoseGiven")
              .HasMaxLength(50);

            builder.Property(p => p.ConcernWithStaff)
             .HasColumnName("ConcernWithStaff")
              .IsRequired();

            builder.Property(p => p.ConcertWithClient)
             .HasColumnName("ConcertWithClient")
              .IsRequired();

            builder.Property(p => p.StaffRotaId)
             .HasColumnName("StaffRotaId")
              .IsRequired();

            #endregion

        }
    }
}
