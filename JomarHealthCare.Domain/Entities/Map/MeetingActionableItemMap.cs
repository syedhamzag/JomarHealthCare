using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MeetingActionableItemMap : IEntityTypeConfiguration<MeetingActionableItem>
    {
        public void Configure(EntityTypeBuilder<MeetingActionableItem> builder)
        {
            builder.ToTable("tbl_MeetingActionableItem");
            builder.HasKey(k => k.MeetingActionableItemId);

            #region Properties
            builder.Property(p => p.MeetingActionableItemId)
               .HasColumnName("MeetingActionableItemId")
               .IsRequired();

            builder.Property(p => p.ActionableItem)
              .HasColumnName("ActionableItem")
              .IsRequired();

            builder.Property(p => p.MeetingLogId)
             .HasColumnName("MeetingLogId")
             .IsRequired();

            #endregion
        }
    }
}
