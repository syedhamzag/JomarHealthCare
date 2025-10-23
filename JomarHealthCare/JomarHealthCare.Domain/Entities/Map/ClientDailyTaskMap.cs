using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientDailyTaskMap : IEntityTypeConfiguration<ClientDailyTask>
    {
        public void Configure(EntityTypeBuilder<ClientDailyTask> builder)
        {
            builder.ToTable("tbl_ClientDailyTask");
            builder.HasKey(k => k.DailyTaskId);

            #region Properties

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.DailyTaskName)
               .HasColumnName("DailyTaskName")
               .HasMaxLength(256);

            builder.Property(p => p.HowToPerformTask)
               .HasColumnName("HowToPerformTask");

            builder.Property(p => p.Image)
                .HasColumnName("Image")
                .HasMaxLength(1024);

            builder.Property(p => p.Video)
                .HasColumnName("Video")
                .HasMaxLength(1024);

            builder.Property(p => p.Date)
              .HasColumnName("Date");

            builder.Property(p => p.AmendmentDate)
             .HasColumnName("AmendmentDate");
            #endregion

            #region Relation
            builder.HasOne(p => p.Client)
                 .WithMany(p => p.ClientDailyTask)
                 .HasForeignKey(p => p.ClientId);
            #endregion
        }
    }
}
