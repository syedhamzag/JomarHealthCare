using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    class PerformanceIndicatorMap : IEntityTypeConfiguration<PerformanceIndicator>
    {
        public void Configure(EntityTypeBuilder<PerformanceIndicator> builder)
        {
            builder.ToTable("tbl_PerformanceIndicator");
            builder.HasKey(k => k.PerformanceIndicatorId);

            #region Properties

            builder.Property(p => p.Heading)
               .HasColumnName("Heading")
               .IsRequired();

            builder.Property(p => p.Date)
               .HasColumnName("Date")
               .IsRequired();

            builder.Property(p => p.DueDate)
               .HasColumnName("DueDate")
               .IsRequired();

            builder.Property(p => p.Rating)
               .HasColumnName("Rating")
               .IsRequired();

            builder.Property(p => p.Remarks)
               .HasColumnName("Remarks")
               .IsRequired();

            #endregion

            #region Relationship
            builder.HasMany<PerformanceIndicatorTask>(p => p.PerformanceIndicatorTask)
                .WithOne(p => p.PerformanceIndicator)
                .HasForeignKey(p => p.PerformanceIndicatorId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
