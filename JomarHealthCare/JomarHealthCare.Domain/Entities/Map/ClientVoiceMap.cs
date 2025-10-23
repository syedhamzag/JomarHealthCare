using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientVoiceMap : IEntityTypeConfiguration<ClientVoice>
    {
        public void Configure(EntityTypeBuilder<ClientVoice> builder)
        {
            builder.ToTable("tbl_Client_Voice");
            builder.HasKey(k => k.VoiceId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.AreasOfImprovements)
               .HasColumnName("AreasOfImprovements")
               .HasMaxLength(2024);

            builder.Property(p => p.SomethingSpecial)
               .HasColumnName("SomethingSpecial")
               .HasMaxLength(2024);

            builder.Property(p => p.HealthGoalShortTerm)
               .HasColumnName("HealthGoalShortTerm")
               .HasMaxLength(2024);

            builder.Property(p => p.HealthGoalLongTerm)
               .HasColumnName("HealthGoalLongTerm")
               .HasMaxLength(2024);

            builder.Property(p => p.ActionRequired)
               .HasColumnName("ActionRequired")
               .HasMaxLength(2024);

            builder.Property(p => p.EvidenceOfActionTaken)
             .HasColumnName("EvidenceOfActionTaken")
             .HasMaxLength(2024);

            builder.Property(p => p.ActionsTakenByMPCC)
               .HasColumnName("ActionsTakenByMPCC")
               .HasMaxLength(2024);

            builder.Property(p => p.Remarks)
               .HasColumnName("Remarks")
               .HasMaxLength(2024);

            builder.Property(p => p.RotCause)
             .HasColumnName("RotCause")
             .HasMaxLength(2024);

            builder.Property(p => p.LessonLearntAndShared)
             .HasColumnName("LessonLearntAndShared")
             .HasMaxLength(2024);

            builder.Property(p => p.URL)
             .HasColumnName("URL")
             .HasMaxLength(1024);

            builder.Property(p => p.Attachment)
             .HasColumnName("Attachment")
             .HasMaxLength(1024);
            #endregion

            #region Relationship
            // builder.HasOne(p => p.Client)
            //      .WithMany(p => p.ClientVoice)
            //      .HasForeignKey(p => p.CompanyId)
            //      .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<VoiceOfficerToAct>(p => p.OfficerToAct)
            //    .WithOne(p => p.Voice)
            //    .HasForeignKey(p => p.VoiceId)
            //    .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
