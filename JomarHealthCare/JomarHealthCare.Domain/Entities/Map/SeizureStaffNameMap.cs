using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class SeizureStaffNameMap : IEntityTypeConfiguration<SeizureStaffName>
    {
        public void Configure(EntityTypeBuilder<SeizureStaffName> builder)
        {
            builder.ToTable("tbl_Seizure_StaffName");
            builder.HasKey(k => k.SeizureStaffNameId);

            #region Properties
            builder.Property(p => p.SeizureStaffNameId)
               .HasColumnName("SeizureStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.SeizureId)
             .HasColumnName("SeizureId")
             .IsRequired();

            #endregion
        }
    }
}
