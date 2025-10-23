using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ChatNotificationMap : IEntityTypeConfiguration<ChatNotification>
    {
        public void Configure(EntityTypeBuilder<ChatNotification> builder)
        {
            builder.ToTable("tbl_chatNotification");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Notification)
               .HasColumnName("Notification")
               .IsRequired();

            builder.Property(p => p.NotifyTime)
              .HasColumnName("NotifyTime")
              .IsRequired();

            builder.Property(p => p.Deleted)
              .HasColumnName("Deleted")
              .IsRequired();

            #endregion
        }
    }
}
