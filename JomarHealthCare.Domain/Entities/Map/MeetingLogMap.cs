using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MeetingLogMap : IEntityTypeConfiguration<MeetingLog>
    {
        public void Configure(EntityTypeBuilder<MeetingLog> builder)
        {
            builder.ToTable("tbl_MeetingLog");
            builder.HasKey(k => k.MeetingLogId);

            #region Properties

            builder.Property(p => p.MeetingLogId)
               .HasColumnName("MeetingLogId")
               .IsRequired();

            builder.Property(p => p.Date)
               .HasColumnName("Date")
               .IsRequired();

            builder.Property(p => p.TimeOFMeeting)
               .HasColumnName("TimeOFMeeting")
               .IsRequired();

            builder.Property(p => p.TypeOfMeeting)
               .HasColumnName("TypeOfMeeting")
               .IsRequired();

            builder.Property(p => p.LocationOfMeeting)
               .HasColumnName("LocationOfMeeting")
               .IsRequired();

            builder.Property(p => p.TimeAllocated)
               .HasColumnName("TimeAllocated");

            builder.Property(p => p.DeadLineForFeedback)
               .HasColumnName("DeadLineForFeedback")
               .IsRequired();

            builder.Property(p => p.NextMeetingDueDate)
               .HasColumnName("NextMeetingDueDate")
               .IsRequired();

            builder.Property(p => p.ClosingRemark)
               .HasColumnName("ClosingRemark")
               .IsRequired();

            builder.Property(p => p.NoteTakerContact)
               .HasColumnName("NoteTakerContact")
               .IsRequired();

            builder.Property(p => p.NoteTakerId)
               .HasColumnName("NoteTakerId")
               .IsRequired();

            builder.Property(p => p.CreatedBy)
     .HasColumnName("CreatedBy")
     .IsRequired(false);
            #endregion

            #region Relationship

            builder.HasMany<MeetingLogFacilitator>(p => p.MeetingLogFacilitators)
                .WithOne(p => p.MeetingLog)
                .HasForeignKey(p => p.MeetingLogId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<MeetingLogResponsibleToAct>(p => p.MeetingLogResponsibleToAct)
                .WithOne(p => p.MeetingLog)
                .HasForeignKey(p => p.MeetingLogId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<MeetingLogAttende>(p => p.MeetingLogAttende)
                .WithOne(p => p.MeetingLog)
                .HasForeignKey(p => p.MeetingLogId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<MeetingAgenda>(p => p.MeetingAgenda)
             .WithOne(p => p.MeetingLog)
             .HasForeignKey(p => p.MeetingLogId)
             .OnDelete(DeleteBehavior.Cascade);

                 builder.HasMany<MeetingDiscussions>(p => p.MeetingDiscussions)
                  .WithOne(p => p.MeetingLog)
                  .HasForeignKey(p => p.MeetingLogId)
                 .OnDelete(DeleteBehavior.Cascade);

                     builder.HasMany<MeetingActionableItem>(p => p.MeetingActionableItem)
                     .WithOne(p => p.MeetingLog)
                    .HasForeignKey(p => p.MeetingLogId)
                     .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }

}
