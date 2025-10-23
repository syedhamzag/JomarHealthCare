using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CallDetailMap : IEntityTypeConfiguration<CallDetail>
    {
        public void Configure(EntityTypeBuilder<CallDetail> builder)
        {

            builder.ToTable("tbl_CallDetail");
            builder.HasKey(p => p.CallDetailId);

            #region Properties

            builder.Property(p => p.NameOfCaller)
                 .HasColumnName("NameOfCaller")
                 .HasMaxLength(100)
                 .IsRequired();

            builder.Property(p => p.CallDetailId)
                .HasColumnName("CallDetailId")
                .IsRequired();

            builder.Property(p => p.DateOfCall)
            .HasColumnName("DateOfCall")
            .IsRequired();


            builder.Property(p => p.TimeOfCall)
               .HasColumnName("TimeOfCall")
               .IsRequired();

            builder.Property(p => p.FeedBack)
              .HasColumnName("FeedBack")
              .HasMaxLength(100)
              .IsRequired();

            builder.Property(p => p.Brief)
              .HasColumnName("Brief")
              .HasMaxLength(100)
              .IsRequired();


            #endregion


        }
    }
}
