using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ContractTemplateMap : IEntityTypeConfiguration<ContractTemplate>
    {
        public void Configure(EntityTypeBuilder<ContractTemplate> builder)
        {
            builder.ToTable("tbl_ContractTemplate");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.TemplateName)
               .HasColumnName("TemplateName")
               .HasMaxLength(256);

            builder.Property(p => p.Template)
               .HasColumnName("Template");

            builder.Property(p => p.JobPositionId)
              .HasColumnName("JobPositionId");

            builder.Property(p => p.CreatedBy)
             .HasColumnName("CreatedBy")
             .HasMaxLength(450);
            #endregion
        }
    }
}
