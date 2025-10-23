using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CommunicationLogApologiesMap : IEntityTypeConfiguration<CommunicationLogApologies>
    {
        public void Configure(EntityTypeBuilder<CommunicationLogApologies> builder)
        {
            builder.ToTable("tbl_CommunicationLogApologies");
            builder.HasKey(k => k.CommunicationLogApologiesId);

            #region Properties
            builder.Property(p => p.CommunicationLogApologiesId)
               .HasColumnName("CommunicationLogApologiesId")
               .IsRequired();

            builder.Property(p => p.ApologiesId)
              .HasColumnName("ApologiesId")
              .HasMaxLength(38)
              .IsRequired();

            builder.Property(p => p.CommunicationLogId)
             .HasColumnName("CommunicationLogId")
             .IsRequired();

            #endregion
        }
    }
}
