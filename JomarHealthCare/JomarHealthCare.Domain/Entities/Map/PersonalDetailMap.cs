using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PersonalDetailMap : IEntityTypeConfiguration<PersonalDetail>
    {
        public void Configure(EntityTypeBuilder<PersonalDetail> builder)
        {
            builder.ToTable("tbl_PersonalDetail");
            builder.HasKey(k => k.PersonalDetailId);

            #region Properties

            builder.Property(p => p.PersonalDetailId)
               .HasColumnName("PersonalDetailId")
               .IsRequired();

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.StaffSignature)
               .HasColumnName("StaffSignature")
               .HasMaxLength(1024);

            builder.Property(p => p.ManagerSignature)
               .HasColumnName("ManagerSignature")
               .HasMaxLength(1024);

            builder.Property(p => p.ClientSignature)
               .HasColumnName("ClientSignature")
               .HasMaxLength(1024);
            #endregion
        }
    }
}
