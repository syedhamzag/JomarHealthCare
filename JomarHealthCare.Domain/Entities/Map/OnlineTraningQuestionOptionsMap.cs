using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    internal class OnlineTraningQuestionOptionsMap: IEntityTypeConfiguration<OnlineTraningQuestionOptions>
    {
        public void Configure(EntityTypeBuilder<OnlineTraningQuestionOptions> builder)
        {
            builder.ToTable("tbl_OnlineTraningQuestionOptions");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Option)
             .HasColumnName("Option")
             .HasMaxLength(1024);

            builder.Property(p => p.OptionMarks)
            .HasColumnName("OptionMarks"); 
            
            builder.Property(p => p.OnlineTraningQuestionId)
            .HasColumnName("OnlineTraningQuestionId");

            #endregion

            #region Relationship
            builder.HasOne(p => p.OnlineTraningQuestion)
             .WithMany(p => p.OnlineTraningQuestionOptions)
             .HasForeignKey(p => p.OnlineTraningQuestionId)
             .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
