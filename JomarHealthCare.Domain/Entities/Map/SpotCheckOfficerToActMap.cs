using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class SpotCheckOfficerToActMap : IEntityTypeConfiguration<SpotCheckOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<SpotCheckOfficerToAct> builder)
        {
            builder.ToTable("tbl_SpotCheck_OfficerToAct");
            builder.HasKey(k => k.SpotCheckOfficerToActId);

            #region Properties
            builder.Property(p => p.SpotCheckOfficerToActId)
               .HasColumnName("SpotCheckOfficerToActId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.SpotCheckId)
             .HasColumnName("SpotCheckId")
             .IsRequired();

            #endregion
        }
    }
}
