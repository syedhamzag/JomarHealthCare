using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientMatrixAuditMap : IEntityTypeConfiguration<ClientMatrixAudit>
    {
        public void Configure(EntityTypeBuilder<ClientMatrixAudit> builder)
        {
            builder.ToTable("tbl_ClientMatrixAudit");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.CompanyId)
               .HasColumnName("ClientId");

            builder.Property(p => p.AuditorName)
               .HasColumnName("AuditorName")
               .HasMaxLength(100);

            builder.Property(p => p.StartDate)
            .HasColumnName("StartDate");

            builder.Property(p => p.EndDate)
            .HasColumnName("EndDate");

            builder.Property(p => p.closingStatement)
            .HasColumnName("closingStatement");

            builder.Property(p => p.IsMedAudit)
            .HasColumnName("IsMedAudit");

            #endregion
        }
    }
}
