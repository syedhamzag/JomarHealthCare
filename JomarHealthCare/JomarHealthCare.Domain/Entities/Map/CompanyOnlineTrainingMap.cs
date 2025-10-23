using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CompanyOnlineTrainingMap : IEntityTypeConfiguration<CompanyOnlineTraining>
    {
        public void Configure(EntityTypeBuilder<CompanyOnlineTraining> builder)
        {
            builder.ToTable("tbl_CompanyOnlineTraining");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.CompanyId)
             .HasColumnName("CompanyId");

            builder.Property(p => p.OnlineTrainingId)
            .HasColumnName("OnlineTrainingId");
            #endregion
        }
    }
}
