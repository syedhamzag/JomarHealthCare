using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class IncidentTypeMap : IEntityTypeConfiguration<IncidentType>
    {
        public void Configure(EntityTypeBuilder<IncidentType> builder)
        {
            builder.ToTable("tbl_IncidentType");
            builder.HasKey(p => p.IncidentTypeId);

            #region Properties
            builder.Property(p => p.IncidentTypeId)
                .HasColumnName("IncidentTypeId")
                .IsRequired();

            builder.Property(p => p.IncidentTypes)
                .HasColumnName("IncidentTypes")
                .HasMaxLength(128);

            builder.Property(p => p.CompanyId)
                .HasColumnName("CompanyId")
                .HasMaxLength(38);
            #endregion
        }
    }
}
