using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OralCareMap : IEntityTypeConfiguration<OralCare>
    {
        public void Configure(EntityTypeBuilder<OralCare> builder)
        {
            builder.ToTable("tbl_OralCare");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.ClientId)
             .HasColumnName("ClientId")
             .HasMaxLength(38);

            builder.Property(p => p.ManyTimeClean)
             .HasColumnName("ManyTimeClean")
             .HasMaxLength(1024);

            builder.Property(p => p.AnyOralRelatedProblemDetail)
             .HasColumnName("AnyOralRelatedProblemDetail")
             .HasMaxLength(1024);

            builder.Property(p => p.LookIntoMouth)
             .HasColumnName("LookIntoMouth")
             .HasMaxLength(1024);

            builder.Property(p => p.AnyBarriersFinding)
             .HasColumnName("AnyBarriersFinding")
             .HasMaxLength(1024);

            builder.Property(p => p.UncomfortableDetail)
             .HasColumnName("UncomfortableDetail")
             .HasMaxLength(1024);

            builder.Property(p => p.OtherMouthCareItems)
             .HasColumnName("OtherMouthCareItems")
             .HasMaxLength(1024);

            builder.Property(p => p.OtherTypes)
             .HasColumnName("OtherTypes")
             .HasMaxLength(1024);

            builder.Property(p => p.DentureCleanAny)
             .HasColumnName("DentureCleanAny")
             .HasMaxLength(1024);

            builder.Property(p => p.DenturePotLocated)
             .HasColumnName("DenturePotLocated")
             .HasMaxLength(1024);

            builder.Property(p => p.Summary)
             .HasColumnName("Summary")
             .HasMaxLength(1024);

            #endregion
        }
    }
}
