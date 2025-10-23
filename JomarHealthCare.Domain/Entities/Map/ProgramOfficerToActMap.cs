using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ProgramOfficerToActMap : IEntityTypeConfiguration<ProgramOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<ProgramOfficerToAct> builder)
        {
            builder.ToTable("tbl_Program_OfficerToAct");
            builder.HasKey(k => k.ProgramOfficerToActId);

            #region Properties
            builder.Property(p => p.ProgramOfficerToActId)
               .HasColumnName("ProgramOfficerToActId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.ProgramId)
             .HasColumnName("ProgramId")
             .IsRequired();

            #endregion
        }
    }
}
