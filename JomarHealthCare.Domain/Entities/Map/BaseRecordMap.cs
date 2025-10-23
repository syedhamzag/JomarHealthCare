using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    internal class BaseRecordMap : IEntityTypeConfiguration<BaseRecords>
    {
        public void Configure(EntityTypeBuilder<BaseRecords> builder)
        {
            builder.ToTable("tbl_BaseRecord");
            builder.HasKey(p => p.BaseRecordId);

            #region Properties
            builder.Property(p => p.KeyName)
                 .HasColumnName("KeyName")
                 .HasMaxLength(256);

            builder.Property(p => p.Description)
             .HasColumnName("Description")
             .HasMaxLength(512);
            #endregion
        }
    }
}
