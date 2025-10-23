using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientServiceWatchMap : IEntityTypeConfiguration<ClientServiceWatch>
    {
        public void Configure(EntityTypeBuilder<ClientServiceWatch> builder)
        {
            builder.ToTable("tbl_Client_ServiceWatch");
            builder.HasKey(k => k.WatchId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Remarks)
               .HasColumnName("Remarks")
               .HasMaxLength(2024);

            builder.Property(p => p.Observation)
             .HasColumnName("Observation")
             .HasMaxLength(2024);

            builder.Property(p => p.ActionRequired)
             .HasColumnName("ActionRequired")
             .HasMaxLength(2024);

            builder.Property(p => p.URL)
             .HasColumnName("URL")
             .HasMaxLength(1024);

            builder.Property(p => p.Attachment)
             .HasColumnName("Attachment")
             .HasMaxLength(1024);
            #endregion

            #region Relationship
            // builder.HasOne(p => p.Client)
            //      .WithMany(p => p.ClientServiceWatch)
            //      .HasForeignKey(p => p.CompanyId)
            //      .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<ServiceStaffName>(p => p.StaffName)
            //    .WithOne(p => p.Service)
            //    .HasForeignKey(p => p.ServiceId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<ServiceOfficerToAct>(p => p.OfficerToAct)
            //    .WithOne(p => p.Service)
            //    .HasForeignKey(p => p.ServiceId)
            //    .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
