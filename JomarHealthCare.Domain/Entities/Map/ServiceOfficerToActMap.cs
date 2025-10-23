using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ServiceOfficerToActMap : IEntityTypeConfiguration<ServiceOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<ServiceOfficerToAct> builder)
        {
            builder.ToTable("tbl_Service_OfficerToAct");
            builder.HasKey(k => k.ServiceOfficerToActId);

            #region Properties
            builder.Property(p => p.ServiceOfficerToActId)
               .HasColumnName("ServiceOfficerToActId")
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
