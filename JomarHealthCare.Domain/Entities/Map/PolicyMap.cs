using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PolicyMap : IEntityTypeConfiguration<Policy>
    {
        public void Configure(EntityTypeBuilder<Policy> builder)
        {
            builder.ToTable("tbl_Policy");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Date)
               .HasColumnName("Date");

            builder.Property(p => p.PolicyName)
               .HasColumnName("PolicyName")
               .HasMaxLength(512);

            builder.Property(p => p.PolicyURl)
               .HasColumnName("PolicyURl")
               .HasMaxLength(512);

            builder.Property(p => p.Remark)
               .HasColumnName("Remark")
               .HasMaxLength(512);

            builder.Property(p => p.Attachment)
               .HasColumnName("Attachment")
               .HasMaxLength(512);

            builder.Property(p => p.ExpireDate)
               .HasColumnName("ExpireDate");
            #endregion
        }
    }
}
