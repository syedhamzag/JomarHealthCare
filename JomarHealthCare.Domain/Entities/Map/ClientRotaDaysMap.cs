using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientRotaDaysMap : IEntityTypeConfiguration<ClientRotaDays>
    {
        public void Configure(EntityTypeBuilder<ClientRotaDays> builder)
        {
            builder.ToTable("tbl_ClientRotaDays");
            builder.HasKey(p => p.ClientRotaDaysId);

            #region Properties
            builder.Property(p => p.ClientRotaDaysId)
                .HasColumnName("ClientRotaDaysId")
                .IsRequired();

            builder.Property(p => p.StartTime)
             .HasColumnName("StartTime")
             .HasMaxLength(25);

            builder.Property(p => p.StopTime)
             .HasColumnName("StopTime")
              .HasMaxLength(25);

            builder.Property(p => p.WeekDay)
            .HasColumnName("WeekDay")
             .HasMaxLength(25);

            builder.Property(p => p.OtherStaff)
            .HasColumnName("OtherStaff")
             .HasMaxLength(38);
            #endregion

            #region Relationships
            builder.HasOne(p => p.ClientRota)
                .WithMany(p => p.ClientRotaDays)
                .HasForeignKey(p => p.ClientRotaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.RotaDayofWeek)
                .WithMany(p => p.ClientRotaDays)
                .HasForeignKey(p => p.RotaDayofWeekId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.Rota)
                .WithMany(m => m.ClientRotaDays)
                .HasForeignKey(f => f.RotaId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
