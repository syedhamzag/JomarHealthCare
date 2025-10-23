using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class DutyOnCallPersonResponsibleMap : IEntityTypeConfiguration<DutyOnCallPersonResponsible>
    {
        public void Configure(EntityTypeBuilder<DutyOnCallPersonResponsible> builder)
        {
            builder.ToTable("tbl_DutyOnCallPersonResponsible");
            builder.HasKey(k => k.PersonResponsibleId);

            #region Properties
            builder.Property(p => p.PersonResponsibleId)
               .HasColumnName("PersonResponsibleId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .HasMaxLength(38);

            builder.Property(p => p.DutyOnCallId)
             .HasColumnName("DutyOnCallId")
             .IsRequired();

            #endregion
        }
    }
}
