using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BodyMapMap : IEntityTypeConfiguration<BodyMap>
    {
        public void Configure(EntityTypeBuilder<BodyMap> builder)
        {
            builder.ToTable("tbl_BodyMap");
            builder.HasKey(k => k.BodyMapId);

            #region Properties
            builder.Property(p => p.StaffRotaPeriodId)
             .HasColumnName("StaffRotaPeriodId");

            builder.Property(p => p.ClientId)
             .HasColumnName("ClientId")
             .HasMaxLength(37);

            builder.Property(p => p.CreamName)
                .HasColumnName("CreamName")
                .HasMaxLength(256)
                .IsRequired(false);

            builder.Property(p => p.PurposeOfCream)
                .HasColumnName("PurposeOfCream")
                .IsRequired(false);

            builder.Property(p => p.Date)
            .HasColumnName("Date")
            .IsRequired(false);

            builder.Property(p => p.HowToApply)
            .HasColumnName("HowToApply")
            .IsRequired(false);

            builder.Property(p => p.Instruction)
            .HasColumnName("Instruction")
            .IsRequired(false);

            builder.Property(p => p.AreaApplied)
            .HasColumnName("AreaApplied")
            .HasMaxLength(512)
            .IsRequired(false);

            builder.Property(p => p.Escalation)
            .HasColumnName("Escalation")
            .HasMaxLength(512)
            .IsRequired(false);
            #endregion


        }
    }
}
