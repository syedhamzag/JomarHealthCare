using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffSupervisionAppraisalMap : IEntityTypeConfiguration<StaffSupervisionAppraisal>
    {
        public void Configure(EntityTypeBuilder<StaffSupervisionAppraisal> builder)
        {
            builder.ToTable("tbl_Staff_SupervisionAppraisal");
            builder.HasKey(k => k.StaffSupervisionAppraisalId);

            #region Properties
            builder.Property(p => p.Reference)
               .HasColumnName("Reference")
               .IsRequired();

            builder.Property(p => p.StaffId)
               .HasColumnName("StaffId")
               .IsRequired();

            builder.Property(p => p.Date)
               .HasColumnName("Date")
               .IsRequired();

            builder.Property(p => p.NextCheckDate)
               .HasColumnName("NextCheckDate");

            builder.Property(p => p.Details)
               .HasColumnName("Details")
               .IsRequired();

            builder.Property(p => p.StaffRating)
               .HasColumnName("StaffRating")
               .HasMaxLength(38)
               .IsRequired();

            builder.Property(p => p.ProfessionalDevelopment)
               .HasColumnName("ProfessionalDevelopment")
               .HasMaxLength(38)
               .IsRequired();

            builder.Property(p => p.StaffComplaints)
               .HasColumnName("StaffComplaints")
               .HasMaxLength(38)
               .IsRequired();

            builder.Property(p => p.FiveStarRating)
               .HasColumnName("FiveStarRating")
               .IsRequired();

            builder.Property(p => p.StaffDevelopment)
               .HasColumnName("StaffDevelopment")
               .IsRequired();

            builder.Property(p => p.StaffAbility)
               .HasColumnName("StaffAbility")
               .IsRequired();

            builder.Property(p => p.NoAbilityToSupport)
               .HasColumnName("NoAbilityToSupport")
               .IsRequired();

            builder.Property(p => p.CondourAndWhistleBlowing)
               .HasColumnName("CondourAndWhistleBlowing")
               .IsRequired();

            builder.Property(p => p.NoCondourAndWhistleBlowing)
               .HasColumnName("NoCondourAndWhistleBlowing")
               .IsRequired();

            builder.Property(p => p.StaffSupportAreas)
               .HasColumnName("StaffSupportAreas")
               .HasMaxLength(38)
               .IsRequired();

            builder.Property(p => p.ActionRequired)
               .HasColumnName("ActionRequired")
               .IsRequired();

            builder.Property(p => p.Deadline)
               .HasColumnName("Deadline")
               .IsRequired();

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .HasMaxLength(38)
               .IsRequired();

            builder.Property(p => p.Remarks)
               .HasColumnName("Remarks")
               .IsRequired();

            builder.Property(p => p.URL)
               .HasColumnName("URL");

            builder.Property(p => p.Accomplishment)
            .HasColumnName("Accomplishment")
            .IsRequired(false);

            builder.Property(p => p.Likemostaboutthisjob)
           .HasColumnName("Likemostaboutthisjob")
           .IsRequired(false);

            builder.Property(p => p.Topthreepriorities)
           .HasColumnName("Topthreepriorities")
           .IsRequired(false);

            builder.Property(p => p.Managementhelped)
           .HasColumnName("Managementhelped")
           .IsRequired(false);

            builder.Property(p => p.Companyvalue)
           .HasColumnName("Companyvalue")
           .IsRequired(false);

            builder.Property(p => p.Goingforward)
           .HasColumnName("Goingforward")
           .IsRequired(false);


            builder.Property(p => p.Trainingdoyouwish)
           .HasColumnName("Trainingdoyouwish")
           .IsRequired(false);

            builder.Property(p => p.Areyouhappyworking)
            .HasColumnName("Areyouhappyworking")
            .IsRequired(false);


            builder.Property(p => p.Wouldyourecommend)
            .HasColumnName("Wouldyourecommend")
            .IsRequired(false);


            builder.Property(p => p.Isthereanytraining)
           .HasColumnName("Isthereanytraining")
           .IsRequired(false);

            builder.Property(p => p.PreventionofAbuseAndSafeguarding)
           .HasColumnName("PreventionofAbuseAndSafeguarding")
           .IsRequired(false);

            builder.Property(p => p.ArethereAnyChanges)
            .HasColumnName("ArethereAnyChanges")
            .IsRequired(false);

            builder.Property(p => p.DoYouHaveAnyQuestions)
           .HasColumnName("DoYouHaveAnyQuestions")
           .IsRequired(false);

            builder.Property(p => p.FeedbackFromManager)
           .HasColumnName("FeedbackFromManager")
           .IsRequired(false);

            builder.Property(p => p.BiggestAchievement)
           .HasColumnName("BiggestAchievement")
           .IsRequired(false);

            builder.Property(p => p.YouContinueToDisplay)
           .HasColumnName("YouContinueToDisplay")
           .IsRequired(false);

            builder.Property(p => p.WhatChallenges)
            .HasColumnName("WhatChallenges")
            .IsRequired(false);

            builder.Property(p => p.AreThereAnyChallenges)
           .HasColumnName("AreThereAnyChallenges")
           .IsRequired(false);

            builder.Property(p => p.WhatLearningAndDevelopment)
           .HasColumnName("WhatLearningAndDevelopment")
           .IsRequired(false);

            builder.Property(p => p.PromoteIndependence)
           .HasColumnName("PromoteIndependence")
           .IsRequired(false);

            builder.Property(p => p.WantToAchieve)
           .HasColumnName("WantToAchieve")
           .IsRequired(false);

            builder.Property(p => p.CRBinfo)
           .HasColumnName("CRBinfo")
           .IsRequired(false);

            builder.Property(p => p.Anyquestions)
           .HasColumnName("Anyquestions")
           .IsRequired(false);

            builder.Property(p => p.FeedbackFromSupervisor)
            .HasColumnName("FeedbackFromSupervisor")
            .IsRequired(false);

            builder.Property(p => p.Attachment)
               .HasColumnName("Attachment")
               .IsRequired();

            builder.Property(p => p.Type)
            .HasColumnName("Type")
            .HasMaxLength(50);
            #endregion

            #region Relationship

            // builder.HasOne(p => p.Staff)
            //      .WithMany(p => p.StaffSupervisionAppraisal)
            //      .HasForeignKey(p => p.StaffId)
            //      .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<SupervisionWorkteam>(p => p.Workteam)
                .WithOne(p => p.Supervision)
                .HasForeignKey(p => p.StaffSupervisionAppraisalId)
                .OnDelete(DeleteBehavior.Cascade);

            // builder.HasMany<SupervisionOfficerToAct>(p => p.OfficerToAct)
            //     .WithOne(p => p.Supervision)
            //     .HasForeignKey(p => p.StaffSupervisionAppraisalId)
            //     .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
