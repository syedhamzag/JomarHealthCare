using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MentalHealthSupportMap : IEntityTypeConfiguration<MentalHealthSupport>
    {
        public void Configure(EntityTypeBuilder<MentalHealthSupport> builder)
        {
            builder.ToTable("tbl_MentalHealthSupport");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.ClientId)
             .HasColumnName("ClientId")
             .HasMaxLength(38);

            builder.Property(p => p.OftenNeedSupport)
             .HasColumnName("OftenNeedSupport")
             .HasMaxLength(1024);

            builder.Property(p => p.StaffPreference)
             .HasColumnName("StaffPreference")
             .HasMaxLength(1024);

            builder.Property(p => p.MethodAndApproach)
             .HasColumnName("MethodAndApproach")
             .HasMaxLength(1024);

            builder.Property(p => p.DoesNotWorkAndLike)
             .HasColumnName("DoesNotWorkAndLike")
             .HasMaxLength(1024);

            builder.Property(p => p.WiderWorkHealthCare)
             .HasColumnName("WiderWorkHealthCare")
             .HasMaxLength(1024);

            builder.Property(p => p.ImportantCloseThem)
             .HasColumnName("ImportantCloseThem")
             .HasMaxLength(1024);

            builder.Property(p => p.DoneInTheirLive)
             .HasColumnName("DoneInTheirLive")
             .HasMaxLength(1024);

            builder.Property(p => p.SomethingEnjoyed)
             .HasColumnName("SomethingEnjoyed")
             .HasMaxLength(1024);


            builder.Property(p => p.TowardTheirGoals)
             .HasColumnName("TowardTheirGoals")
             .HasMaxLength(1024);

            builder.Property(p => p.Keyworker)
             .HasColumnName("Keyworker")
             .HasMaxLength(1024);

            builder.Property(p => p.StrengthBases)
             .HasColumnName("StrengthBases")
             .HasMaxLength(1024);

            #endregion


        }
    }
}
