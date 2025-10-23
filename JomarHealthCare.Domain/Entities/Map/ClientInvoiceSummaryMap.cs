using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientInvoiceSummaryMap : IEntityTypeConfiguration<ClientInvoiceSummary>
    {
        public void Configure(EntityTypeBuilder<ClientInvoiceSummary> builder)
        {
            builder.ToTable("tbl_ClientInvoiceSummary");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.FromDate)
               .HasColumnName("FromDate");

            builder.Property(p => p.ToDate)
               .HasColumnName("ToDate");

            builder.Property(p => p.Period)
               .HasColumnName("Period")
               .HasMaxLength(50);

            builder.Property(p => p.ServiceTypeId)
               .HasColumnName("ServiceTypeId");

            builder.Property(p => p.CreatedBy)
               .HasColumnName("CreatedBy")
               .HasMaxLength(450);
            #endregion
        }
    }
}
