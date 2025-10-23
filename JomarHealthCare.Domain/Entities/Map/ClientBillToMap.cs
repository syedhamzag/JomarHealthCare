using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientBillToMap : IEntityTypeConfiguration<ClientBillTo>
    {
        public void Configure(EntityTypeBuilder<ClientBillTo> builder)
        {
            builder.ToTable("tbl_ClientBillTo");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Email)
               .HasColumnName("Email")
               .HasMaxLength(250);

            builder.Property(p => p.BillTo)
               .HasColumnName("BillTo")
               .HasMaxLength(1024);

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId");
            #endregion

            #region Relation
            builder.HasOne(p => p.Client)
                 .WithMany(p => p.ClientBillTo)
                 .HasForeignKey(p => p.ClientId);
            #endregion
        }
    }
}
