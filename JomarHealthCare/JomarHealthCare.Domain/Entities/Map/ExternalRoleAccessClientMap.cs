using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ExternalRoleAccessClientMap : IEntityTypeConfiguration<ExternalRoleAccessClient>
    {
        public void Configure(EntityTypeBuilder<ExternalRoleAccessClient> builder)
        {
            builder.ToTable("tbl_ExternalRoleAccessClient");
            builder.HasKey(k => k.ExternalRoleAccessClientId);

            #region Properties
            builder.Property(p => p.ExternalRoleAccessClientId)
               .HasColumnName("ExternalRoleAccessClientId")
               .IsRequired();

            builder.Property(p => p.ClientId)
              .HasMaxLength(38)
              .HasColumnName("ClientId")
              .IsRequired();

            builder.Property(p => p.ExternalAccessId)
             .HasColumnName("ExternalAccessId")
             .IsRequired();

            #endregion
        }
    }
}
