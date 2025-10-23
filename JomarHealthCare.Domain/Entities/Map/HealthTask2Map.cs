using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HealthTask2Map : IEntityTypeConfiguration<HealthTask2>
    {
        public void Configure(EntityTypeBuilder<HealthTask2> builder)
        {
            builder.ToTable("tbl_HealthTask2");
            builder.HasKey(k => k.HealthTask2Id);

            #region Properties

            builder.Property(p => p.BestId)
               .HasColumnName("BestId")
               .IsRequired();

            builder.Property(p => p.Heading2Id)
                .HasColumnName("Heading2Id")
                .IsRequired();

            builder.Property(p => p.Title)
                .HasColumnName("Title")
                .IsRequired();

            builder.Property(p => p.Answer)
                .HasColumnName("Answer")
                .IsRequired();

            builder.Property(p => p.Remark)
                .HasColumnName("Remark")
                .IsRequired();

            #endregion
        }
    }
}
