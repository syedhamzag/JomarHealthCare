using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffContractMap : IEntityTypeConfiguration<StaffContract>
    {
        public void Configure(EntityTypeBuilder<StaffContract> builder)
        {
            builder.ToTable("tbl_StaffContract");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.ContactId)
               .HasColumnName("ContactId");

            builder.Property(p => p.StaffId)
               .HasColumnName("StaffId");

            builder.Property(p => p.Template)
              .HasColumnName("Template");

            builder.Property(p => p.StaffSignature)
             .HasColumnName("StaffSignature")
             .HasMaxLength(1024);

            builder.Property(p => p.StaffSignatureDate)
             .HasColumnName("StaffSignatureDate");
            
            builder.Property(p => p.HRSignature)
             .HasColumnName("HRSignature")
             .HasMaxLength(1024);

            builder.Property(p => p.HRSignatureDate)
             .HasColumnName("HRSignatureDate");
            #endregion
        }
    }
}
