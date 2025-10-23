using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientInvoiceRateMap : IEntityTypeConfiguration<ClientInvoiceRate>
    {
        public void Configure(EntityTypeBuilder<ClientInvoiceRate> builder)
        {
            builder.ToTable("tbl_ClientInvoiceRate");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId");

            builder.Property(p => p.ServiceType)
               .HasColumnName("ServiceType")
               .HasMaxLength(256);

            builder.Property(p => p.Period)
               .HasColumnName("Period")
               .HasMaxLength(50);

            builder.Property(p => p.Rate)
               .HasColumnName("Rate");
            #endregion

            #region Relation
            builder.HasOne(p => p.Client)
                 .WithMany(p => p.ClientInvoiceRate)
                 .HasForeignKey(p => p.ClientId);
            #endregion
        }
    }
}
