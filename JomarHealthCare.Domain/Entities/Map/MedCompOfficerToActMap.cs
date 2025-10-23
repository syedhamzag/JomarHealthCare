using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MedCompOfficerToActMap : IEntityTypeConfiguration<MedCompOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<MedCompOfficerToAct> builder)
        {
            builder.ToTable("tbl_MedComp_OfficerToAct");
            builder.HasKey(k => k.MedCompOfficerToActId);

            #region Properties
            builder.Property(p => p.MedCompOfficerToActId)
               .HasColumnName("MedCompOfficerToActId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.MedCompId)
             .HasColumnName("MedCompId")
             .IsRequired();

            #endregion
        }
    }
}
