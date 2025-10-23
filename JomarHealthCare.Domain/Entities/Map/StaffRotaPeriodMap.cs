using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffRotaPeriodMap : IEntityTypeConfiguration<StaffRotaPeriod>
    {
        public void Configure(EntityTypeBuilder<StaffRotaPeriod> builder)
        {
            builder.ToTable("tbl_StaffRotaPeriod");
            builder.HasKey(k => k.StaffRotaPeriodId);

            #region Properties
            builder.Property(p => p.StaffRotaPeriodId)
                .HasColumnName("StaffRotaPeriodId")
                .IsRequired();

            builder.Property(p => p.StaffRotaId)
                .HasColumnName("StaffRotaId")
                .IsRequired();

            builder.Property(p => p.ClientRotaTypeId)
              .HasColumnName("ClientRotaTypeId")
              .IsRequired();


            builder.Property(p => p.ClockInAddress)
               .HasColumnName("ClockInAddress")
               .HasMaxLength(256);

            builder.Property(p => p.ClockOutAddress)
               .HasColumnName("ClockOutAddress")
               .HasMaxLength(256);

            builder.Property(p => p.Feedback)
               .HasColumnName("Feedback")
               .HasMaxLength(2024);

            builder.Property(p => p.Comment)
               .HasColumnName("Comment")
               .HasMaxLength(2024);

            builder.Property(p => p.HandOver)
               .HasColumnName("HandOver")
               .HasMaxLength(256);

            builder.Property(p => p.ClockInMode)
               .HasColumnName("ClockInMode")
               .HasMaxLength(256);

            builder.Property(p => p.ClockOutMode)
               .HasColumnName("ClockOutMode")
               .HasMaxLength(256);

            builder.Property(p => p.StartTime)
              .HasColumnName("StartTime")
              .HasMaxLength(50);

            builder.Property(p => p.StopTime)
              .HasColumnName("StopTime")
              .HasMaxLength(50);

            builder.Property(p => p.ClientId)
             .HasColumnName("ClientId")
             .HasMaxLength(38);


            builder.Property(p => p.BowelMovement)
             .HasColumnName("BowelMovement")
             .HasMaxLength(5);

            builder.Property(p => p.OralCare)
              .HasColumnName("OralCare")
              .HasMaxLength(5);

            builder.Property(p => p.FluidIntake)
             .HasColumnName("FluidIntake")
             .HasMaxLength(5);

            builder.Property(p => p.ClockInClientTelephone)
                .HasColumnName("ClockInClientTelephone")
                .HasMaxLength(50);

            builder.Property(p => p.ClockOutClientTelephone)
               .HasColumnName("ClockOutClientTelephone")
               .HasMaxLength(50);

            builder.Property(p => p.ClockInGeolocation)
              .HasColumnName("ClockInGeolocation")
              .HasMaxLength(1000);

            builder.Property(p => p.ClockOutGeolocation)
             .HasColumnName("ClockOutGeolocation")
             .HasMaxLength(1000);

            builder.Property(p => p.ClockOutClientTelephone)
              .HasColumnName("ClockOutClientTelephone")
              .HasMaxLength(50);

            builder.Property(p => p.ClockInDistance)
            .HasColumnName("ClockInDistance")
            .HasMaxLength(50);

            builder.Property(p => p.ClockOutDistance)
               .HasColumnName("ClockOutDistance")
               .HasMaxLength(50);

            builder.Property(p => p.MealIntake)
               .HasColumnName("MealIntake")
               .HasMaxLength(1024);

            builder.Property(p => p.BodyMap)
               .HasColumnName("BodyMap")
               .HasMaxLength(1024);

            builder.Property(p => p.forcedEntry)
               .HasColumnName("forcedEntry")
               .HasMaxLength(1024);

            builder.Property(p => p.forcedExit)
               .HasColumnName("forcedExit")
               .HasMaxLength(1024);

            builder.Property(p => p.reasonExceeding)
               .HasColumnName("reasonExceeding")
               .HasMaxLength(1024);

            builder.Property(p => p.Signature)
               .HasColumnName("Signature")
               .HasMaxLength(1024);

            builder.Property(p => p.UpcomingplannedTask)
               .HasColumnName("UpcomingplannedTask")
               .HasMaxLength(1024);


            builder.Property(p => p.LatenessComments)
                .HasColumnName("LatenessComments")
                .HasMaxLength(1024);

            builder.Property(p => p.AlertComment)
                .HasColumnName("AlertComment")
                .HasMaxLength(1024);
            #endregion

            #region Relationship
            builder.HasOne(b => b.StaffRota)
                .WithMany(b => b.StaffRotaPeriods)
                .HasForeignKey(k => k.StaffRotaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(b => b.ClientRotaType)
                .WithMany(c => c.StaffRotaPeriods)
                .HasForeignKey(f => f.ClientRotaTypeId);
            #endregion
        }
    }
}
