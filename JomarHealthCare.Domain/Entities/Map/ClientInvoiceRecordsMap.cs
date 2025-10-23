using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientInvoiceRecordsMap : IEntityTypeConfiguration<ClientInvoiceRecords>
    {
        public void Configure(EntityTypeBuilder<ClientInvoiceRecords> builder)
        {
            builder.ToTable("tbl_ClientInvoiceRecords");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .HasMaxLength(1024);

            builder.Property(p => p.FromDate)
               .HasColumnName("FromDate");

            builder.Property(p => p.ToDate)
               .HasColumnName("ToDate");

            builder.Property(p => p.Number)
               .HasColumnName("Number");

            builder.Property(p => p.Notes)
            .HasColumnName("Notes")
            .HasMaxLength(1024);

            builder.Property(p => p.ClientInvoiceId)
            .HasColumnName("ClientInvoiceId");
            #endregion

            #region Relationship

            builder.HasOne(p => p.ClientInvoice)
             .WithMany(p => p.ClientInvoiceRecords)
             .HasForeignKey(p => p.ClientInvoiceId)
             .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
