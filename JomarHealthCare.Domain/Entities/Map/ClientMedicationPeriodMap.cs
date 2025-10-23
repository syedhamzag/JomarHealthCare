using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientMedicationPeriodMap : IEntityTypeConfiguration<ClientMedicationPeriod>
    {
        public void Configure(EntityTypeBuilder<ClientMedicationPeriod> builder)
        {
            builder.ToTable("tbl_ClientMedicationPeriod");
            builder.HasKey(k => k.ClientMedicationPeriodId);

            #region Properties
            builder.Property(p => p.ClientMedicationPeriodId)
                .HasColumnName("ClientMedicationPeriodId")
                .IsRequired();
            #endregion

            #region Relationship
            builder.HasOne(o => o.ClientMedicationDay)
                .WithMany(m => m.ClientMedicationPeriod)
                .HasForeignKey(f => f.ClientMedicationDayId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
