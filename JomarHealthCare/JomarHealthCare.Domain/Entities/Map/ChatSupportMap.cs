using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ChatSupportMap : IEntityTypeConfiguration<ChatSupport>
    {
        public void Configure(EntityTypeBuilder<ChatSupport> builder)
        {
            builder.ToTable("tbl_chatsupport");
            builder.HasKey(k => k.Id);

            #region Properties

            //builder.HasOne(p => p.User)
            //   .WithMany(p => p.ChatSupport)
            //   .HasForeignKey(p => p.ToUserId)
            //   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.ChatType)
               .HasColumnName("ChatType")
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