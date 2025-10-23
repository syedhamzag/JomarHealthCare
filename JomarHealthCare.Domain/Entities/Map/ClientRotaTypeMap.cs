using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientRotaTypeMap : IEntityTypeConfiguration<ClientRotaType>
    {
        public void Configure(EntityTypeBuilder<ClientRotaType> builder)
        {
            builder.ToTable("tbl_ClientRotaType");
            builder.HasKey(p => p.ClientRotaTypeId);

            #region Properties
            builder.Property(p => p.ClientRotaTypeId)
                .HasColumnName("ClientRotaTypeId")
                .IsRequired();

            builder.Property(p => p.RotaType)
                .HasColumnName("RotaType")
                .HasMaxLength(128);

            builder.Property(p => p.CompanyId)
                .HasColumnName("CompanyId")
                .HasMaxLength(38);
            #endregion
        }
    }
}
