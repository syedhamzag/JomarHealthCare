using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffPersonalInfoMap : IEntityTypeConfiguration<StaffPersonalInfo>
    {
        public void Configure(EntityTypeBuilder<StaffPersonalInfo> builder)
        {
            builder.ToTable("tbl_StaffPersonalInfo");
            builder.HasKey(k => k.StaffPersonalInfoId);

            #region Properties

            builder.Property(p => p.RegistrationId)
               .HasColumnName("RegistrationId")
               .HasMaxLength(25);

            builder.Property(p => p.FirstName)
               .HasColumnName("FirstName")
               .HasMaxLength(50);

            builder.Property(p => p.MiddleName)
               .HasColumnName("MiddleName")
               .HasMaxLength(50);

            builder.Property(p => p.LastName)
               .HasColumnName("LastName")
               .HasMaxLength(50);


            builder.Property(p => p.Telephone)
               .HasColumnName("Telephone")
               .HasMaxLength(50);

            builder.Property(p => p.ProfilePix)
               .HasColumnName("ProfilePix")
               .HasMaxLength(1024);

            builder.Property(p => p.Address)
               .HasColumnName("Address")
               .HasMaxLength(225);

            builder.Property(p => p.AboutMe)
               .HasColumnName("AboutMe")
               .HasMaxLength(2048);

            builder.Property(p => p.Hobbies)
               .HasColumnName("Hobbies")
               .HasMaxLength(225);

            builder.Property(p => p.Email)
               .HasColumnName("Email")
               .HasMaxLength(225);

            builder.Property(p => p.Keyworker)
               .HasColumnName("Keyworker")
               .HasMaxLength(50);

            builder.Property(p => p.IdNumber)
               .HasColumnName("IdNumber")
               .HasMaxLength(50);

            builder.Property(p => p.Gender)
               .HasColumnName("Gender")
               .HasMaxLength(7);

            builder.Property(p => p.PostCode)
               .HasColumnName("PostCode")
               .HasMaxLength(50);


            builder.Property(p => p.TeamLeader)
               .HasColumnName("TeamLeader")
               .HasMaxLength(50);

            builder.Property(p => p.WorkTeam)
               .HasColumnName("WorkTeam")
               .HasMaxLength(50);

            builder.Property(p => p.StaffWorkTeamId)
              .HasColumnName("StaffWorkTeamId");


            builder.Property(p => p.Passcode)
              .HasColumnName("Passcode")
              .HasMaxLength(15);


            builder.Property(p => p.DrivingLicense)
               .HasColumnName("DrivingLicense")
               .HasMaxLength(1024);

            builder.Property(p => p.RightToWorkAttachment)
              .HasColumnName("RightToWorkAttachment")
              .HasMaxLength(1024);


            builder.Property(p => p.DBSAttachment)
               .HasColumnName("DBSAttachment")
               .HasMaxLength(1024);


            builder.Property(p => p.DBSUpdateNo)
               .HasColumnName("DBSUpdateNo")
                .HasMaxLength(50);


            builder.Property(p => p.NIAttachment)
              .HasColumnName("NIAttachment")
              .HasMaxLength(1024);

            builder.Property(p => p.CV)
              .HasColumnName("CV")
              .HasMaxLength(1024);

            builder.Property(p => p.CoverLetter)
              .HasColumnName("CoverLetter")
              .HasMaxLength(1024);

            builder.Property(p => p.Self_PYEAttachment)
            .HasColumnName("Self_PYEAttachment")
           .HasMaxLength(1024);


            builder.Property(p => p.PlaceOfBirth)
          .HasColumnName("PlaceOfBirth")
          .HasMaxLength(50);

            builder.Property(p => p.StaffManager)
            .HasColumnName("StaffManager")
            .HasMaxLength(450);

            builder.Property(p => p.JobPositionId)
            .HasColumnName("JobPositionId");


            builder.Property(p => p.ClassOfStaff)
            .HasColumnName("ClassOfStaff")
            .HasMaxLength(150);

            builder.Property(p => p.COSNo)
            .HasColumnName("COSNo")
            .HasMaxLength(50);

            builder.Property(p => p.BRPAttachment)
            .HasColumnName("BRPAttachment")
            .HasMaxLength(1024);

            builder.Property(p => p.PassportAttachment)
            .HasColumnName("PassportAttachment")
            .HasMaxLength(1024);

            builder.Property(p => p.RegistrationNo)
            .HasColumnName("RegistrationNo")
            .HasMaxLength(100);

            builder.Property(p => p.HomeOfficeDecisionLetter)
            .HasColumnName("HomeOfficeDecisionLetter")
            .HasMaxLength(1024);

            builder.Property(p => p.RightToPracticeAttachment)
              .HasColumnName("RightToPracticeAttachment")
              .HasMaxLength(1024);

            builder.Property(p => p.RightToPracticeCode)
              .HasColumnName("RightToPracticeCode")
              .HasMaxLength(100);

            builder.Property(p => p.RightToPracticeExpiryDate)
               .HasColumnName("RightToPracticeExpiryDate")
               .IsRequired(false);
            #endregion

            builder.HasIndex(p => p.RegistrationId)
                         .HasName("IX_tbl_StaffPersonalInfo_RegistrationId")
                         .IsUnique(true);

            // builder.HasMany<StaffOfficeLocation>(p => p.StaffOfficeLocation)
            //     .WithOne(p => p.StaffPersonalInfo)
            //     .HasForeignKey(p => p.StaffId)
            //     .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.ApplicationUser)
              .WithOne(u => u.StaffPersonalInfo)
              .HasForeignKey<ApplicationUser>(u => u.StaffId);

            builder.HasOne(p => p.CategoryOfStaff)
                   .WithMany(c => c.StaffPersonalInfo)
                   .HasForeignKey(p => p.CategoryId);

            builder.HasOne(p => p.JobPosition)
              .WithMany(u => u.StaffPersonalInfo)
              .HasForeignKey(u => u.JobPositionId);

        }
    }
}
