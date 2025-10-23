using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ServiceStaffNameMap : IEntityTypeConfiguration<ServiceStaffName>
    {
        public void Configure(EntityTypeBuilder<ServiceStaffName> builder)
        {
            builder.ToTable("tbl_Service_StaffName");
            builder.HasKey(k => k.ServiceStaffNameId);

            #region Properties
            builder.Property(p => p.ServiceStaffNameId)
               .HasColumnName("ServiceStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.ServiceId)
             .HasColumnName("ServiceId")
             .IsRequired();

            #endregion
        }
    }
}
