using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientInvoiceMap : IEntityTypeConfiguration<ClientInvoice>
    {
        public void Configure(EntityTypeBuilder<ClientInvoice> builder)
        {
            builder.ToTable("tbl_ClientInvoice");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId");

            builder.Property(p => p.InvoiceDate)
               .HasColumnName("InvoiceDate");

            builder.Property(p => p.BillTo)
               .HasColumnName("BillTo")
               .HasMaxLength(1024);

            builder.Property(p => p.InvoiceNo)
               .HasColumnName("InvoiceNo");

            builder.Property(p => p.InvoiceNoWithMonth)
               .HasColumnName("InvoiceNoWithMonth");

            builder.Property(p => p.PeriodType)
               .HasColumnName("PeriodType")
               .HasMaxLength(30);

            builder.Property(p => p.Credit)
            .HasColumnName("Credit");

            builder.Property(p => p.Charges)
            .HasColumnName("Charges");

            builder.Property(p => p.Total)
            .HasColumnName("Total");

            builder.Property(p => p.ClientInvoiceSummaryId)
            .HasColumnName("ClientInvoiceSummaryId");

            builder.Property(p => p.ClienBillToId)
            .HasColumnName("ClienBillToId");
            #endregion

            #region Relationship

            builder.HasOne(p => p.ClientInvoiceSummary)
             .WithMany(p => p.ClientInvoice)
             .HasForeignKey(p => p.ClientInvoiceSummaryId)
             .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
