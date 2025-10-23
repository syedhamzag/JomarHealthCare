using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OnlineMaterialTypeMap : IEntityTypeConfiguration<OnlineMaterialType>
    {
        public void Configure(EntityTypeBuilder<OnlineMaterialType> builder)
        {
            builder.ToTable("tbl_OnlineMaterialType");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Name)
             .HasColumnName("Name")
             .HasMaxLength(250);

            builder.Property(p => p.CreatedBy)
            .HasColumnName("CreatedBy")
            .HasMaxLength(450);

            #endregion
        }
    }
}
