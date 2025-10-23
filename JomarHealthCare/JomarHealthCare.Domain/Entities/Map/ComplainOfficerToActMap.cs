using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ComplainOfficerToActMap : IEntityTypeConfiguration<ComplainOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<ComplainOfficerToAct> builder)
        {
            builder.ToTable("tbl_Complain_OfficerToAct");
            builder.HasKey(k => k.ComplainOfficerToActId);

            #region Properties
            builder.Property(p => p.ComplainOfficerToActId)
               .HasColumnName("ComplainOfficerToActId")
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
