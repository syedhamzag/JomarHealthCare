using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ExpenselogMap: IEntityTypeConfiguration<Expenselog>
    {
        public void Configure(EntityTypeBuilder<Expenselog> builder)
        {
            builder.ToTable("tbl_Expenselog");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.ExpenseDate)
             .HasColumnName("EexpenseDate");

            builder.Property(p => p.ReferenceNo)
             .HasColumnName("ReferenceNo")
             .HasMaxLength(50);

            builder.Property(p => p.StaffId)
                .HasColumnName("StaffId");

            builder.Property(p => p.ItemOfPurchase)
                .HasColumnName("ItemOfPurchase")
                .HasMaxLength(1024);

            builder.Property(p => p.Quantity)
            .HasColumnName("Quantity");

            builder.Property(p => p.Price)
            .HasColumnName("Price");

            builder.Property(p => p.AmountGivenAdvance)
            .HasColumnName("AmountGivenAdvance");

            builder.Property(p => p.ReturnBalance)
            .HasColumnName("ReturnBalance");

            builder.Property(p => p.ProofOfPurchase)
            .HasColumnName("ProofOfPurchase");
            
            builder.Property(p => p.PurchaseDate)
            .HasColumnName("PurchaseDate");

            builder.Property(p => p.LocationOfPurchase)
            .HasColumnName("LocationOfPurchase")
            .HasMaxLength (512);

            builder.Property(p => p.ReceiptNo)
            .HasColumnName("ReceiptNo")
            .HasMaxLength (124);

            builder.Property(p => p.WhoApproved)
            .HasColumnName("WhoApproved")
            .HasMaxLength (450);

            builder.Property(p => p.Remarks)
            .HasColumnName("Remarks")
            .HasMaxLength (1024);
            
            builder.Property(p => p.CompanyId)
            .HasColumnName("CompanyId")
            .HasMaxLength (450);

            builder.Property(p => p.ClientId)
                .HasColumnName("ClientId");
            #endregion
        }
    }
}
