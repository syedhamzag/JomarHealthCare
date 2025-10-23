using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BMIChartOfficerToActMap : IEntityTypeConfiguration<BMIChartOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<BMIChartOfficerToAct> builder)
        {
            builder.ToTable("tbl_BMIChart_OfficerToAct");
            builder.HasKey(k => k.BMIChartOfficerToActId);

            #region Properties
            builder.Property(p => p.BMIChartOfficerToActId)
               .HasColumnName("BMIChartOfficerToActId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.BMIChartId)
             .HasColumnName("BMIChartId")
             .IsRequired();

            #endregion
        }
    }
}
