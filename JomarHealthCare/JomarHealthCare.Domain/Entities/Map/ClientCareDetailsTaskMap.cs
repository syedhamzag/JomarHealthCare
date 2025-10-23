using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientCareDetailsTaskMap : IEntityTypeConfiguration<ClientCareDetailsTask>
    {
        public void Configure(EntityTypeBuilder<ClientCareDetailsTask> builder)
        {
            builder.ToTable("tbl_ClientCareDetailsTask");
            builder.HasKey(k => k.ClientCareDetailsTaskId);

            #region Properties
            builder.Property(p => p.ClientCareDetailsTaskId)
              .HasColumnName("ClientCareDetailsTaskId")
              .IsRequired();

            builder.Property(p => p.ClientCareDetailsHeadingId)
              .HasColumnName("ClientCareDetailsHeadingId")
              .IsRequired();

            builder.Property(p => p.Task)
                .HasColumnName("Task")
                .HasMaxLength(225)
                .IsRequired();

            builder.Property(p => p.Deleted)
                .HasColumnName("Deleted")
                .HasDefaultValue<bool>(false);
            #endregion

            #region Relationship
            builder.HasOne(p => p.ClientCareDetailsHeading)
                .WithMany(p => p.ClientCareDetailsTasks)
                .HasForeignKey(p => p.ClientCareDetailsHeadingId);

            #endregion
        }
    }
}
