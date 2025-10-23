using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class RecentProjectMap : IEntityTypeConfiguration<RecentProject>
    {
        public void Configure(EntityTypeBuilder<RecentProject> builder)
        {
            builder.ToTable("tbl_RecentProject");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .IsRequired();

            builder.Property(p => p.CreatedDate)
               .HasColumnName("CreatedDate")
               .IsRequired();

            builder.Property(p => p.Progress)
               .HasColumnName("Progress")
               .IsRequired();
            builder.Property(p => p.CreatedBy)
                        .HasColumnName("CreatedBy");
            #endregion
        }
    }
}
