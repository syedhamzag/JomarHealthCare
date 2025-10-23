using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientKeyWorkerVoiceMap : IEntityTypeConfiguration<ClientKeyWorkerVoice>
    {
        public void Configure(EntityTypeBuilder<ClientKeyWorkerVoice> builder)
        {
            builder.ToTable("tbl_ClientKeyWorkerVoice");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.KeyWorkerId)
               .HasColumnName("KeyWorkerId");

            builder.Property(p => p.StartDate)
               .HasColumnName("StartDate");

            builder.Property(p => p.EndDate)
               .HasColumnName("EndDate");

            builder.Property(p => p.Status)
              .HasColumnName("Status")
              .HasMaxLength(50);

            builder.Property(p => p.StaffId)
               .HasColumnName("staffId");
            #endregion
        }
    }
}
