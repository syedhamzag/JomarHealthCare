using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientTaskBoardAssignedToMap : IEntityTypeConfiguration<ClientTaskBoardAssignedTo>
    {
        public void Configure(EntityTypeBuilder<ClientTaskBoardAssignedTo> builder)
        {
            builder.ToTable("tbl_ClientTaskBoardAssignedTo");
            builder.HasKey(k => k.TaskBoardAssignedToId);

            #region Properties
            builder.Property(p => p.TaskBoardAssignedToId)
               .HasColumnName("TaskBoardAssignedToId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.TaskBoardId)
             .HasColumnName("TaskBoardId")
             .IsRequired();

            #endregion
        }
    }
}
