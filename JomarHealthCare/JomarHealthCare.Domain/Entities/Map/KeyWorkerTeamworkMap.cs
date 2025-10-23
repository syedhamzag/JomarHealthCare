using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class KeyWorkerWorkteamMap : IEntityTypeConfiguration<KeyWorkerWorkteam>
    {
        public void Configure(EntityTypeBuilder<KeyWorkerWorkteam> builder)
        {
            builder.ToTable("tbl_KeyWorker_StaffName");
            builder.HasKey(k => k.KeyWorkerWorkteamId);

            #region Properties
            builder.Property(p => p.KeyWorkerWorkteamId)
               .HasColumnName("KeyWorkerWorkteamId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.KeyWorkerId)
             .HasColumnName("KeyWorkerId")
             .IsRequired();

            #endregion
        }
    }
}
