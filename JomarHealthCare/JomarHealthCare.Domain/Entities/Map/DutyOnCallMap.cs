using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class DutyOnCallMap : IEntityTypeConfiguration<DutyOnCall>
    {
        public void Configure(EntityTypeBuilder<DutyOnCall> builder)
        {
            builder.ToTable("tbl_DutyOnCall");
            builder.HasKey(k => k.DutyOnCallId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.ActionTaken)
             .HasColumnName("ActionTaken")
             .HasMaxLength(2048);

            builder.Property(p => p.Attachment)
             .HasColumnName("Attachment")
             .HasMaxLength(1024);

            builder.Property(p => p.ClientInitial)
             .HasColumnName("ClientInitial")
             .HasMaxLength(1024);

            builder.Property(p => p.DateOfIncident)
             .HasColumnName("DateOfIncident")
             .IsRequired();

            builder.Property(p => p.DetailsOfIncident)
             .HasColumnName("DetailsOfIncident")
             .HasMaxLength(2048);

            builder.Property(p => p.DetailsRequired)
             .HasColumnName("DetailsRequired")
             .HasMaxLength(2048);

            builder.Property(p => p.RefNo)
             .HasColumnName("RefNo")
             .HasMaxLength(20);

            builder.Property(p => p.Remarks)
             .HasColumnName("Remarks")
             .HasMaxLength(2048);

            builder.Property(p => p.ReportedBy)
             .HasColumnName("ReportedBy")
             .HasMaxLength(1024);

            builder.Property(p => p.Subject)
             .HasColumnName("Subject")
             .HasMaxLength(256);

            #endregion

            #region Relationship

            builder.HasMany<DutyOnCallPersonResponsible>(p => p.PersonResponsible)
                .WithOne(p => p.DutyOnCall)
                .HasForeignKey(p => p.DutyOnCallId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<DutyOnCallPersonToAct>(p => p.PersonToAct)
                .WithOne(p => p.DutyOnCall)
                .HasForeignKey(p => p.DutyOnCallId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Client)
                .WithMany(p => p.DutyOnCall)
                .HasForeignKey(p => p.ClientId);
            #endregion
        }
    }
}
