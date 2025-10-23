using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{

    public class ChatSupportAssignedStaffMap : IEntityTypeConfiguration<ChatSupportAssignedStaff>
    {
        public void Configure(EntityTypeBuilder<ChatSupportAssignedStaff> builder)
        {
            builder.ToTable("tbl_ChatSupportAssignedStaff");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.CreatedDate)
               .HasColumnName("CreatedDate")
               .IsRequired();

            builder.Property(p => p.ToUserId)
              .HasColumnName("ToUserId")
              .IsRequired(true);

            builder.Property(p => p.ChatSupportId)
           .HasColumnName("ChatSupportId")
           .IsRequired(true);

            builder.Property(p => p.Deleted)
              .HasColumnName("Deleted")
              .IsRequired();

            #endregion
        }
    }

}
