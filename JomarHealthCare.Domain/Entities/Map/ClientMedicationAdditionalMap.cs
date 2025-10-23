using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientMedicationAdditionalMap : IEntityTypeConfiguration<ClientMedicationAdditional>
    {
        public void Configure(EntityTypeBuilder<ClientMedicationAdditional> builder)
        {
            builder.ToTable("tbl_ClientMedicationAdditional");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.ClientMedicationPeriodId)
            .HasColumnName("ClientMedicationPeriodId")
            .IsRequired(true);

            builder.Property(p => p.DoseTobeGiven)
            .HasColumnName("DoseTobeGiven")
            .HasMaxLength(50);

            builder.Property(p => p.DoseGiven)
            .HasColumnName("DoseGiven")
            .HasMaxLength(256);

            builder.Property(p => p.Instruction)
            .HasColumnName("Instruction")
            .HasMaxLength(1024);

            builder.Property(p => p.FeedBack)
            .HasColumnName("FeedBack")
            .HasMaxLength(1024);

            builder.Property(p => p.Time)
                .HasColumnName("Time");

            builder.Property(p => p.StopTime)
            .HasColumnName("StopTime");

            builder.Property(p => p.RotaDate)
            .HasColumnName("RotaDate")
            .HasMaxLength(10);

            builder.Property(p => p.Status)
            .HasColumnName("Status")
            .HasMaxLength(50);
        }
    }
}
