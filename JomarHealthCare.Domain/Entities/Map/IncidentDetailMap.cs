using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class IncidentDetailMap : IEntityTypeConfiguration<IncidentDetail>
    {
        public void Configure(EntityTypeBuilder<IncidentDetail> builder)
        {
            builder.ToTable("tbl_IncidentDetail");
            builder.HasKey(k => k.IncidentDetailId);

            #region Properties
            builder.Property(p => p.IncidentDetailId)
             .HasColumnName("IncidentDetailId")
             .IsRequired();

            builder.Property(p => p.DateTime)
                .HasColumnName("DateTime")
                .IsRequired();

            builder.Property(p => p.PoliceNotify)
                .HasColumnName("PoliceNotify")
                .IsRequired();

            builder.Property(p => p.PoliceNotifyReference)
                .HasColumnName("PoliceNotifyReference")
                .HasMaxLength(150)
                .IsRequired(false);

            builder.Property(p => p.IncidentDetails)
                .HasColumnName("IncidentDetails")
                .IsRequired();

            builder.Property(p => p.IncidentCauses)
                .HasColumnName("IncidentCauses")
                .IsRequired();

            builder.Property(p => p.Recommendations)
                .HasColumnName("Recommendations")
                .IsRequired();

            builder.Property(p => p.FollowupAction)
                .HasColumnName("FollowupAction")
                .IsRequired();

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .HasMaxLength(20);

            builder.Property(p => p.IncidentType)
               .HasColumnName("IncidentType")
               .HasMaxLength(20);
            #endregion

            #region Relationship
            builder.HasMany<IncidentDetailAssignedTo>(p => p.AssignedTo)
                .WithOne(p => p.IncidentDetail)
                .HasForeignKey(p => p.IncidentDetailId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
