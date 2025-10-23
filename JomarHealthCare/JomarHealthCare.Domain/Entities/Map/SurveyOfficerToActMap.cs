using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class SurveyOfficerToActMap : IEntityTypeConfiguration<SurveyOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<SurveyOfficerToAct> builder)
        {
            builder.ToTable("tbl_Survey_OfficerToAct");
            builder.HasKey(k => k.SurveyOfficerToActId);

            #region Properties
            builder.Property(p => p.SurveyOfficerToActId)
               .HasColumnName("SurveyOfficerToActId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            // builder.Property(p => p.StaffSurveyId)
            //  .HasColumnName("StaffSurveyToActSurveyId")
            //  .IsRequired();

            #endregion
        }
    }
}
