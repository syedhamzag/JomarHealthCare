using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CareObjPersonToActMap : IEntityTypeConfiguration<CareObjPersonToAct>
    {
        public void Configure(EntityTypeBuilder<CareObjPersonToAct> builder)
        {
            builder.ToTable("tbl_CareObjPersonToAct");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.CareObjId)
             .HasColumnName("CareObjId")
             .IsRequired();

            #endregion
        }
    }
}
