using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MeetingDiscussionsMap : IEntityTypeConfiguration<MeetingDiscussions>
    {
        public void Configure(EntityTypeBuilder<MeetingDiscussions> builder)
        {
            builder.ToTable("tbl_MeetingDiscussions");
            builder.HasKey(k => k.MeetingDiscussionId);

            #region Properties
            builder.Property(p => p.MeetingDiscussionId)
               .HasColumnName("MeetingDiscussionId")
               .IsRequired();

            builder.Property(p => p.Discussion)
              .HasColumnName("Discussion")
              .IsRequired();

            builder.Property(p => p.MeetingLogId)
             .HasColumnName("MeetingLogId")
             .IsRequired();

            #endregion
        }
    }
}
