using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ReportedConcernMap : IEntityTypeConfiguration<ReportedConcern>
    {
        public void Configure(EntityTypeBuilder<ReportedConcern> builder)
        {
            builder.ToTable("tbl_ReportedConcern");
            builder.HasKey(p => p.ReportedConcernId);

            #region Properties
            builder.Property(p => p.ReportedConcernId)
                .HasColumnName("ReportedConcernId")
                .IsRequired();

            builder.Property(p => p.ReportedConcernType)
                .HasColumnName("ReportedConcernType")
                .HasMaxLength(128);

            builder.Property(p => p.CompanyId)
                .HasColumnName("CompanyId")
                .HasMaxLength(38);
            #endregion
        }
    }
}
