using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    internal class BaseRecordItemMap : IEntityTypeConfiguration<BaseRecordItems>
    {
        public void Configure(EntityTypeBuilder<BaseRecordItems> builder)
        {
            builder.ToTable("tbl_BaseRecordItem");
            builder.HasKey(p => p.BaseRecordItemId);

            #region Properties
            builder.Property(p => p.ValueName)
                 .HasMaxLength(512);

            builder.Property(p => p.BaseRecordId)
             .HasMaxLength(38);

            builder.Property(p => p.CompanyId)
                .HasMaxLength(38);
            #endregion

            #region Relationship
            builder.HasOne(p => p.BaseRecord)
                     .WithMany(p => p.BaseRecordItems)
                     .HasForeignKey(p => p.BaseRecordId);
            #endregion
        }
    }
}
