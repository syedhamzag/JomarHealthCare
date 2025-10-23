using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{

    public class ConsentLandlineLogMap : IEntityTypeConfiguration<ConsentLandlineLog>
    {
        public void Configure(EntityTypeBuilder<ConsentLandlineLog> builder)
        {
            builder.ToTable("tbl_ConsentLandlineLog");
            builder.HasKey(k => k.ConsentLandlineLogId);

            #region Properties

            builder.Property(p => p.ConsentLandlineLogId)
               .HasColumnName("ConsentLandlineLogId")
               .IsRequired();

            builder.Property(p => p.LandlineId)
                .HasColumnName("LandlineId")
                .IsRequired();

            builder.Property(p => p.BaseRecordId)
               .HasColumnName("BaseRecordId")
               .IsRequired();

            #endregion
        }
    }
}
