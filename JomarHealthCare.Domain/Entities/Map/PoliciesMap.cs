using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PoliciesMap : IEntityTypeConfiguration<Policies>
    {
        public void Configure(EntityTypeBuilder<Policies> builder)
        {
            builder.ToTable("tbl_Policies");
            builder.HasKey(p => p.Id);

            #region Properties
            builder.Property(p => p.Name)
                 .HasColumnName("Name")
                 .HasMaxLength(256);

            builder.Property(p => p.Ref)
             .HasColumnName("Ref")
             .HasMaxLength(256);

            builder.Property(p => p.PolicyOwner)
             .HasColumnName("PolicyOwner")
             .HasMaxLength(256);

            builder.Property(p => p.Link)
             .HasColumnName("Link")
             .HasMaxLength(1024);
            #endregion
        }
    }
}
