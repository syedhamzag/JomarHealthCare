using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CompanyMessageMap : IEntityTypeConfiguration<CompanyMessage>
    {
        public void Configure(EntityTypeBuilder<CompanyMessage> builder)
        {
            builder.ToTable("tbl_CompanyMessage");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.CompanysMessage)
               .HasColumnName("CompanysMessage")
               .HasMaxLength(1025)
               .IsRequired(true);

            builder.Property(p => p.CreatedBy)
               .HasColumnName("CreatedBy")
               .IsRequired();

            builder.Property(p => p.CreatedDate)
               .HasColumnName("CreatedDate")
               .IsRequired();
            #endregion

        }
    }
}
