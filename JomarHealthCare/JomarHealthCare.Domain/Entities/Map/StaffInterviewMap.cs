using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffInterviewMap : IEntityTypeConfiguration<StaffInterview>
    {
        public void Configure(EntityTypeBuilder<StaffInterview> builder)
        {
            builder.ToTable("tbl_StaffInterview");
            builder.HasKey(k => k.StaffInterviewId);

            #region Properties
            builder.Property(p => p.StaffPersonalInfoId)
               .HasColumnName("StaffPersonalInfoId")
               .IsRequired();

            builder.Property(p => p.Heading)
               .HasColumnName("Heading")
               .IsRequired();

            builder.Property(p => p.JobPosition)
               .HasColumnName("JobPosition")
               .HasMaxLength(100);
            #endregion

            #region Relationship
            builder.HasOne(p => p.StaffPersonalInfo)
                 .WithMany(p => p.StaffInterview)
                 .HasForeignKey(p => p.StaffPersonalInfoId)
                 .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<StaffInterviewTask>(p => p.StaffInterviewTask)
                .WithOne(p => p.StaffInterview)
                .HasForeignKey(p => p.StaffInterviewId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
