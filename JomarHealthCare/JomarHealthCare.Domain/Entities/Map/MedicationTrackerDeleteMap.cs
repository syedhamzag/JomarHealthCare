using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MedicationTrackerDeleteMap : IEntityTypeConfiguration<MedicationTrackerDelete>
    {
        public void Configure(EntityTypeBuilder<MedicationTrackerDelete> builder)
        {
            builder.ToTable("tbl_MedicationTrackerDelete");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.Date)
               .HasColumnName("Date");

            builder.Property(p => p.clientMedicationPeriodId)
               .HasColumnName("clientMedicationPeriodId");

            builder.Property(p => p.StaffRotaId)
               .HasColumnName("StaffRotaId");
            #endregion

        }
    }
}
