using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BodyTempPhysicianMap : IEntityTypeConfiguration<BodyTempPhysician>
    {
        public void Configure(EntityTypeBuilder<BodyTempPhysician> builder)
        {
            builder.ToTable("tbl_BodyTemp_Physician");
            builder.HasKey(k => k.BodyTempPhysicianId);

            #region Properties
            builder.Property(p => p.BodyTempPhysicianId)
               .HasColumnName("BodyTempPhysicianId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.BodyTempId)
             .HasColumnName("BodyTempId")
             .IsRequired();

            #endregion
        }
    }
}
