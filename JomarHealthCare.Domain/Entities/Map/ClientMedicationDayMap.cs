using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientMedicationDayMap : IEntityTypeConfiguration<ClientMedicationDay>
    {
        public void Configure(EntityTypeBuilder<ClientMedicationDay> builder)
        {
            builder.ToTable("tbl_ClientMedicationDay");
            builder.HasKey(k => k.ClientMedicationDayId);

            #region Properties
            builder.Property(p => p.ClientMedicationDayId)
                .HasColumnName("ClientMedicationDayId")
                .IsRequired();
            #endregion

            #region Relationship
            builder.HasOne<ClientMedication>()
                .WithMany(m => m.ClientMedicationDay)
                .HasForeignKey(k => k.ClientMedicationId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}
