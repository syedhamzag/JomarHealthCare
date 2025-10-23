using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BaseRecordModelMap : IEntityTypeConfiguration<BaseRecordModel>
    {
        public void Configure(EntityTypeBuilder<BaseRecordModel> builder)
        {
            builder.ToTable("tbl_BaseRecord_Model");
            builder.HasKey(p => p.BaseRecordId);

            #region Properties

            builder.Property(p => p.BaseRecordId)
                .HasColumnName("BaseRecordId")
                .IsRequired();

            builder.Property(p => p.KeyName)
                .HasColumnName("KeyName")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnName("Description")
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(p => p.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasMaxLength(450);
            #endregion

            #region Relationship
            builder.HasMany<BaseRecordItemModel>(p => p.BaseRecordItems)
                .WithOne(p => p.BaseRecord)
                .HasForeignKey(p => p.BaseRecordId)
                .IsRequired();
            #endregion
        }
    }
}
