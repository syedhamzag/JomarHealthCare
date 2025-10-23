using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffOneToOneMap : IEntityTypeConfiguration<StaffOneToOne>
    {
        public void Configure(EntityTypeBuilder<StaffOneToOne> builder)
        {
            builder.ToTable("tbl_Staff_OneToOne");
            builder.HasKey(k => k.OneToOneId);

            #region Properties
            builder.Property(p => p.Reference)
               .HasColumnName("Reference")
               .IsRequired();

            builder.Property(p => p.StaffId)
               .HasColumnName("StaffId")
               .IsRequired();

            builder.Property(p => p.Date)
               .HasColumnName("Date")
               .IsRequired();

            builder.Property(p => p.NextCheckDate)
               .HasColumnName("NextCheckDate");

            builder.Property(p => p.Purpose)
               .HasColumnName("Purpose")
               .IsRequired();

            builder.Property(p => p.PreviousSupervision)
               .HasColumnName("PreviousSupervision")
               .HasMaxLength(38)
               .IsRequired();

            builder.Property(p => p.StaffImprovedInAreas)
               .HasColumnName("StaffImprovedInAreas")
               .IsRequired();

            builder.Property(p => p.CurrentEventArea)
               .HasColumnName("CurrentEventArea")
               .IsRequired();

            builder.Property(p => p.StaffConclusion)
               .HasColumnName("StaffConclusion")
               .IsRequired();

            builder.Property(p => p.DecisionsReached)
               .HasColumnName("DecisionsReached")
               .IsRequired();

            builder.Property(p => p.ImprovementRecorded)
               .HasColumnName("ImprovementRecorded")
               .IsRequired();

            builder.Property(p => p.ActionRequired)
               .HasColumnName("ActionRequired")
               .IsRequired();

            builder.Property(p => p.Deadline)
               .HasColumnName("Deadline")
               .IsRequired();

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .HasMaxLength(38)
               .IsRequired();

            builder.Property(p => p.Remarks)
               .HasColumnName("Remarks")
               .IsRequired();

            builder.Property(p => p.URL)
               .HasColumnName("URL");

            builder.Property(p => p.Attachment)
               .HasColumnName("Attachment")
               .IsRequired();
            #endregion

            #region Relationship
            builder.HasOne(p => p.Staff)
                 .WithMany(p => p.StaffOneToOne)
                 .HasForeignKey(p => p.StaffId)
                 .OnDelete(DeleteBehavior.Cascade);

            // builder.HasMany<OneToOneOfficerToAct>(p => p.OfficerToAct)
            //     .WithOne(p => p.OneToOne)
            //     .HasForeignKey(p => p.OneToOneId)
            //     .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
