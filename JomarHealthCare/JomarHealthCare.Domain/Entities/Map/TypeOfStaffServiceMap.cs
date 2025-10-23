using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class TypeOfStaffServiceMap : IEntityTypeConfiguration<TypeOfStaffService>
    {
        public void Configure(EntityTypeBuilder<TypeOfStaffService> builder)
        {
            builder.ToTable("tbl_TypeOfStaffService");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.ServiceName)
               .HasColumnName("ServiceName")
               .IsRequired();

            builder.Property(p => p.CreatedBy)
             .HasColumnName("CreatedBy")
             .IsRequired(false);
            #endregion
        }
    }
}
