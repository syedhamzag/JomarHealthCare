using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ComplainStaffNameMap : IEntityTypeConfiguration<ComplainStaffName>
    {
        public void Configure(EntityTypeBuilder<ComplainStaffName> builder)
        {
            builder.ToTable("tbl_Complain_StaffName");
            builder.HasKey(k => k.ComplainStaffNameId);

            #region Properties
            builder.Property(p => p.ComplainStaffNameId)
               .HasColumnName("ComplainStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.ComplainId)
             .HasColumnName("ComplainId")
             .IsRequired();

            #endregion
        }
    }
}
