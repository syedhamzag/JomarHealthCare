using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BaseRecordItemModelMap : IEntityTypeConfiguration<BaseRecordItemModel>
    {
        public void Configure(EntityTypeBuilder<BaseRecordItemModel> builder)
        {
            builder.ToTable("tbl_BaseRecordItem_Model");
            builder.HasKey(p => p.BaseRecordItemId);

            #region Properties
            builder.Property(p => p.BaseRecordId)
                .HasColumnName("BaseRecordId")
                .IsRequired();
            builder.Property(p => p.BaseRecordItemId)
               .HasColumnName("BaseRecordItemId")
               .IsRequired();
            builder.Property(p => p.ValueName)
                .HasColumnName("ValueName")
                .IsRequired();
            builder.Property(p => p.Deleted)
                .HasColumnName("Deleted");

            builder.Property(p => p.HasGoogleForm)
               .HasColumnName("HasGoogleForm")
               .HasDefaultValue(false);

            builder.Property(p => p.AddLink)
              .HasColumnName("AddLink")
              .IsRequired(false);

            builder.Property(p => p.ViewLink)
              .HasColumnName("ViewLink")
              .IsRequired(false);

            builder.Property(p => p.ExpiryInMonths)
              .HasColumnName("ExpiryInMonths")
              .HasDefaultValue(0);

            builder.Property(p => p.CreatedBy)
              .HasColumnName("CreatedBy")
              .HasMaxLength(450);
            #endregion
        }
    }
}
