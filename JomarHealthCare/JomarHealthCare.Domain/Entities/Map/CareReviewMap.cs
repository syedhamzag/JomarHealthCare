using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CareReviewMap : IEntityTypeConfiguration<CareReview>
    {
        public void Configure(EntityTypeBuilder<CareReview> builder)
        {
            builder.ToTable("tbl_CareReview");
            builder.HasKey(k => k.CareReviewId);

            #region Properties
            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .IsRequired();

            builder.Property(p => p.Action)
               .HasColumnName("Action")
               .IsRequired();

            builder.Property(p => p.Note)
               .HasColumnName("Note")
               .IsRequired();

            builder.Property(p => p.CompanyId)
               .HasColumnName("ClientId")
               .IsRequired();

            builder.Property(p => p.Date)
               .HasColumnName("Date")
               .IsRequired();
            #endregion

            #region Relation
            // builder.HasOne(p => p.Company)
            //      .WithMany(p => p.CareReview)
            //      .HasForeignKey(p => p.CompanyId)
            //      .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}

