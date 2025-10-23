using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CompanyBankMap : IEntityTypeConfiguration<CompanyBank>
    {
        public void Configure(EntityTypeBuilder<CompanyBank> builder)
        {
            builder.ToTable("tbl_CompanyBank");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.BankName)
             .HasColumnName("BankName")
             .HasMaxLength(256);

            builder.Property(p => p.Title)
             .HasColumnName("Title")
             .HasMaxLength(256);

            builder.Property(p => p.AccountNo)
                .HasColumnName("AccountNo")
                .HasMaxLength(256);

            builder.Property(p => p.TransitNo)
                .HasColumnName("TransitNo")
                .HasMaxLength(100);

            builder.Property(p => p.InstitudionNo)
            .HasColumnName("InstitudionNo")
            .HasMaxLength(100);

            builder.Property(p => p.SortCode)
            .HasColumnName("SortCode")
            .HasMaxLength(100);

            builder.Property(p => p.IsUKBank)
            .HasColumnName("IsUKBank");

            builder.Property(p => p.IsOperating)
            .HasColumnName("IsOperating");

            builder.Property(p => p.CompanyId)
            .HasColumnName("CompanyId")
            .HasMaxLength(450);
            #endregion


        }
    }
}
