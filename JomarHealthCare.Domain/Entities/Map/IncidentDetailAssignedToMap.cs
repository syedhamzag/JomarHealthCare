using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class IncidentDetailAssignedToMap : IEntityTypeConfiguration<IncidentDetailAssignedTo>
    {
        public void Configure(EntityTypeBuilder<IncidentDetailAssignedTo> builder)
        {
            builder.ToTable("tbl_IncidentDetailAssignedTo");
            builder.HasKey(k => k.IncidentDetailAssignedToId);

            #region Properties
            builder.Property(p => p.IncidentDetailAssignedToId)
               .HasColumnName("IncidentDetailAssignedToId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .HasMaxLength(38)
              .IsRequired();

            builder.Property(p => p.IncidentDetailId)
             .HasColumnName("IncidentDetailId")
             .IsRequired();

            builder.Property(p => p.Date)
                .HasColumnName("Date")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnName("Description")
                .HasMaxLength(1024)
                .IsRequired();

            #endregion
        }
    }
}
