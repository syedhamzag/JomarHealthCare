using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class VisitStaffNameMap : IEntityTypeConfiguration<VisitStaffName>
    {
        public void Configure(EntityTypeBuilder<VisitStaffName> builder)
        {
            builder.ToTable("tbl_Visit_StaffName");
            builder.HasKey(k => k.VisitStaffNameId);

            #region Properties
            builder.Property(p => p.VisitStaffNameId)
               .HasColumnName("VisitStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.VisitId)
             .HasColumnName("VisitId")
             .IsRequired();

            #endregion
        }
    }
}
