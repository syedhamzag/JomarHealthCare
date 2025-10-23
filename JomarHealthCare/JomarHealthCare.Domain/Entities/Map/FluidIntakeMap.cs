using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class FluidIntakeMap : IEntityTypeConfiguration<FluidIntake>
    {
        public void Configure(EntityTypeBuilder<FluidIntake> builder)
        {
            builder.ToTable("tbl_FluidIntake");
            builder.HasKey(k => k.FluidIntakeId);   

            #region Properties
            builder.Property(p => p.StaffRotaPeriodId)
             .HasColumnName("StaffRotaPeriodId")
             .IsRequired(false);

            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .IsRequired(false);

            builder.Property(p => p.Dose)
                           .HasColumnName("Dose")
                           .IsRequired(false);


            #endregion


        }
    }
}
