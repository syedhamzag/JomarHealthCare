using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class SurveyWorkteamMap : IEntityTypeConfiguration<SurveyWorkteam>
    {
        public void Configure(EntityTypeBuilder<SurveyWorkteam> builder)
        {
            builder.ToTable("tbl_Survey_StaffName");
            builder.HasKey(k => k.SurveyWorkteamId);

            #region Properties
            builder.Property(p => p.SurveyWorkteamId)
               .HasColumnName("SurveyWorkteamId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.StaffSurveyId)
             .HasColumnName("StaffSurveyId")
             .IsRequired();

            #endregion
        }
    }
}
