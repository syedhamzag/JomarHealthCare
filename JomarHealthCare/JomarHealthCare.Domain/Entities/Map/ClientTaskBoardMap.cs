using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientTaskBoardMap : IEntityTypeConfiguration<ClientTaskBoard>
    {
        public void Configure(EntityTypeBuilder<ClientTaskBoard> builder)
        {
            builder.ToTable("tbl_ClientTaskBoard");
            builder.HasKey(k => k.TaskBoardId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Attachment)
               .HasColumnName("Attachment")
               .HasMaxLength(1024);

            builder.Property(p => p.CompletionDate)
               .HasColumnName("CompletionDate")
               .IsRequired();

            builder.Property(p => p.Note)
               .HasColumnName("Note")
               .IsRequired();

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .IsRequired();

            builder.Property(p => p.Type)
               .HasColumnName("Type")
               .IsRequired();

            builder.Property(p => p.Priority)
               .HasColumnName("Priority")
               .IsRequired();

            builder.Property(p => p.TaskImage)
               .HasColumnName("TaskImage")
               .HasMaxLength(1024);

            builder.Property(p => p.TaskName)
               .HasColumnName("TaskName")
               .HasMaxLength(100)
               .IsRequired();
            builder.Property(p => p.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasMaxLength(38)
                .IsRequired();
            #endregion

            #region Relationship
            builder.HasMany<ClientTaskBoardAssignedTo>(p => p.AssignedTo)
                .WithOne(p => p.ClientTaskBoard)
                .HasForeignKey(p => p.TaskBoardId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
