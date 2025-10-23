using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CompanyTrainingImageMap : IEntityTypeConfiguration<CompanyTrainingImage>
    {
        public void Configure(EntityTypeBuilder<CompanyTrainingImage> builder)
        {
            builder.ToTable("tbl_CompanyTrainingImage");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.CompanyId)
             .HasColumnName("CompanyId");

            builder.Property(p => p.InductionImg)
             .HasColumnName("InductionImg")
             .HasMaxLength(1024);

            builder.Property(p => p.AllCoursesImg)
             .HasColumnName("AllCoursesImg")
             .HasMaxLength(1024);

            builder.Property(p => p.MyCoursesImg)
             .HasColumnName("MyCoursesImg")
             .HasMaxLength(1024);

            builder.Property(p => p.CertificationImg)
             .HasColumnName("CertificationImg")
             .HasMaxLength(1024);

            builder.Property(p => p.LibarayImg)
            .HasColumnName("LibarayImg")
            .HasMaxLength(1024);

            builder.Property(p => p.SupportImg)
            .HasColumnName("SupportImg")
            .HasMaxLength(1024);
            #endregion
        }
    }
}
