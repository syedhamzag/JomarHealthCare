using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CompanyContactModelMap : IEntityTypeConfiguration<CompanyContactModel>
    {
        public void Configure(EntityTypeBuilder<CompanyContactModel> builder)
        {
            builder.ToTable("tbl_CompanyContact");
            builder.HasKey(p => p.CompanyContactId);

            #region Properties
            builder.Property(p => p.CompanyContactId)
                .HasColumnName("CompanyContactId")
                .IsRequired();
            builder.Property(p => p.CompanyId)
               .HasColumnName("CompanyId")
               .IsRequired();

            builder.Property(p => p.Name)
               .HasColumnName("ContactName")
               .HasMaxLength(255)
               .IsRequired();

            builder.Property(p => p.Email)
             .HasColumnName("ContactEmail")
             .HasMaxLength(255)
             .IsRequired();

            builder.Property(p => p.Telephone)
             .HasColumnName("ContactTelephone")
             .HasMaxLength(255)
             .IsRequired();

            #endregion

            #region Relationship
            //builder.HasOne(p => p.Company)
            //    .WithMany(p => p.CompanyContacts)
            //    .HasForeignKey(p => p.CompanyId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}
