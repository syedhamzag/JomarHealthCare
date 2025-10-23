using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class EyeHealthPhysicianMap : IEntityTypeConfiguration<EyeHealthPhysician>
    {
        public void Configure(EntityTypeBuilder<EyeHealthPhysician> builder)
        {
            builder.ToTable("tbl_EyeHealth_Physician");
            builder.HasKey(k => k.EyeHealthPhysicianId);

            #region Properties
            builder.Property(p => p.EyeHealthPhysicianId)
               .HasColumnName("EyeHealthPhysicianId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.EyeHealthId)
             .HasColumnName("EyeHealthId")
             .IsRequired();

            #endregion
        }
    }
}
