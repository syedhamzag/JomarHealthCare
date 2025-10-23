using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ExternalRoleAccessMap : IEntityTypeConfiguration<ExternalRoleAccess>
    {
        public void Configure(EntityTypeBuilder<ExternalRoleAccess> builder)
        {
            builder.ToTable("tbl_ExternalRoleAccess");
            builder.HasKey(p => p.ExternalAccessId);

            builder.Property(p => p.ExternalId)
              .HasColumnName("ExternalId");

            #region Relationship
            builder.HasMany<ExternalRoleAccessClient>(p => p.Client)
                .WithOne(p => p.ExternalRoleAccess)
                .HasForeignKey(p => p.ExternalAccessId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<ExternalRoleAccessStaff>(p => p.Staff)
                .WithOne(p => p.ExternalRoleAccess)
                .HasForeignKey(p => p.ExternalAccessId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
