using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ChatSupportConversationMap : IEntityTypeConfiguration<ChatSupportConversation>
    {
        public void Configure(EntityTypeBuilder<ChatSupportConversation> builder)
        {
            builder.ToTable("tbl_chatsupportconversation");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.HasOne(p => p.ChatSupport)
               .WithMany(p => p.ChatSupportConversation)
               .HasForeignKey(p => p.ChatSupportId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.Property(p => p.Message)
              .HasColumnName("Message")
              .HasMaxLength(1025)
              .IsRequired(true);

            builder.Property(p => p.FilePath)
             .HasColumnName("FilePath")
             .HasMaxLength(125)
             .IsRequired(false);

            builder.Property(p => p.SessionId)
             .HasColumnName("SessionId")
             .HasMaxLength(100)
             .IsRequired(false);

            builder.Property(p => p.OpenTokToken)
             .HasColumnName("OpenTokToken")
             .HasMaxLength(500)
             .IsRequired(false);
            builder.Property(p => p.FromUserId)
            .HasColumnName("FromUserId")
            .IsRequired(false);
            builder.Property(p => p.ToUserId)
            .HasColumnName("ToUserId")
            .IsRequired(false);
            builder.Property(p => p.IsByStaff)
           .HasColumnName("IsByStaff")
           .IsRequired();

            builder.Property(p => p.CreatedDate)
               .HasColumnName("CreatedDate")
               .IsRequired();

            builder.Property(p => p.Deleted)
             .HasColumnName("Deleted")
             .IsRequired();

            #endregion
        }
    }
}
