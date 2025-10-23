using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffShadowingMap : IEntityTypeConfiguration<StaffShadowing>
    {
        public void Configure(EntityTypeBuilder<StaffShadowing> builder)
        {
            builder.ToTable("tbl_StaffShadowing");
            builder.HasKey(k => k.StaffShadowingId);

            #region Properties
            builder.Property(p => p.StaffPersonalInfoId)
               .HasColumnName("StaffPersonalInfoId")
               .IsRequired();

            builder.Property(p => p.Heading)
               .HasColumnName("Heading")
               .IsRequired();

            #endregion

            #region Relationship
            builder.HasOne(p => p.StaffPersonalInfo)
                 .WithMany(p => p.StaffShadowing)
                 .HasForeignKey(p => p.StaffPersonalInfoId)
                 .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<StaffShadowingTask>(p => p.StaffShadowingTask)
                .WithOne(p => p.StaffShadowing)
                .HasForeignKey(p => p.StaffShadowingId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
    

