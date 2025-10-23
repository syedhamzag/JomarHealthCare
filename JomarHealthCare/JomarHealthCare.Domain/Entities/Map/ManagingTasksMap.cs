using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ManagingTasksMap : IEntityTypeConfiguration<ManagingTasks>
    {
        public void Configure(EntityTypeBuilder<ManagingTasks> builder)
        {
            builder.ToTable("tbl_ManagingTasks");
            builder.HasKey(k => k.TaskId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Help)
               .HasColumnName("Help")
               .HasMaxLength(2024);
            #endregion

        }
    }
}
