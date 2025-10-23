using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class JobPositionAccessMap : IEntityTypeConfiguration<JobPositionAccess>
    {
        public void Configure(EntityTypeBuilder<JobPositionAccess> builder)
        {
            builder.ToTable("tbl_JobPositionAccess");
            builder.HasKey(k => k.AccessId);

            #region Properties
            builder.Property(p => p.JobPositionId)
               .HasColumnName("JobPositionId");

            builder.Property(p => p.PageId)
               .HasColumnName("PageId");

            #endregion
        }
    }
}
