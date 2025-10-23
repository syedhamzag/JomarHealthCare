using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffWorkTeamMap : IEntityTypeConfiguration<StaffWorkTeam>
    {
        public void Configure(EntityTypeBuilder<StaffWorkTeam> builder)
        {
            builder.ToTable("tbl_StaffWorkTeam");
            builder.HasKey(p => p.StaffWorkTeamId);

            #region Properties
            builder.Property(p => p.StaffWorkTeamId)
                .HasColumnName("StaffWorkTeamId")
                .IsRequired();

            builder.Property(p => p.WorkTeam)
                .HasColumnName("WorkTeam")
                .IsRequired();

            builder.HasOne(p => p.User)
.WithMany(p => p.StaffWorkTeam)
.HasForeignKey(p => p.CreatedBy)
.OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}
