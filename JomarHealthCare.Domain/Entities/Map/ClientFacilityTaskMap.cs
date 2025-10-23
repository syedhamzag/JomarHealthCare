using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    internal class ClientFacilityTaskMap : IEntityTypeConfiguration<ClientFacilityTask>
    {
        public void Configure(EntityTypeBuilder<ClientFacilityTask> builder)
        {
            builder.ToTable("tbl_ClientFacilityTask");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .HasMaxLength(256);

            builder.Property(p => p.Location)
               .HasColumnName("Location")
               .HasMaxLength(512);

            builder.Property(p => p.BeforePerformingTask)
               .HasColumnName("BeforePerformingTask")
               .HasMaxLength(2000);

            builder.Property(p => p.HowToTaskPerform)
               .HasColumnName("HowToTaskPerform")
               .HasMaxLength(2000);

            builder.Property(p => p.RiskAssociated)
               .HasColumnName("RiskAssociated")
               .HasMaxLength(2000);

            builder.Property(p => p.HowToMigitate)
               .HasColumnName("HowToMigitate")
               .HasMaxLength(2000);

            builder.Property(p => p.WhatToDoAfterTaskCompleting)
               .HasColumnName("WhatToDoAfterTaskCompleting")
               .HasMaxLength(2000);

            builder.Property(p => p.Picture)
               .HasColumnName("Picture")
               .HasMaxLength(1024);

            builder.Property(p => p.Video)
               .HasColumnName("Video")
               .HasMaxLength(1024);
            #endregion

            builder.HasOne(p => p.ClientFacility)
            .WithMany(p => p.ClientFacilityTasks)
            .HasForeignKey(p => p.FacilityClientId);
        }
    }
}
