using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ConversationMap : IEntityTypeConfiguration<Conversation>
    {
        public void Configure(EntityTypeBuilder<Conversation> builder)
        {
            builder.ToTable("tbl_conversation");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.HasOne(p => p.Inbox)
               .WithMany(p => p.Conversation)
               .HasForeignKey(p => p.InboxId)
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
             .IsRequired(true);

            builder.Property(p => p.OpenTokToken)
             .HasColumnName("OpenTokToken")
             .HasMaxLength(500)
             .IsRequired(true);

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
