using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CreateShiftMap : IEntityTypeConfiguration<CreateShift>
    {
        public void Configure(EntityTypeBuilder<CreateShift> builder)
        {

            builder.ToTable("tbl_createshift");
            builder.HasKey(k => k.Id);

            #region Properties


            builder.Property(p => p.RoleAndNumber)
               .HasColumnName("RoleAndNumber")
               .IsRequired();

            builder.Property(p => p.RatePerHour)
               .HasColumnName("RatePerHour")
               .IsRequired();

            builder.Property(p => p.CreatedBy)
               .HasColumnName("CreatedBy")
               .IsRequired();

            builder.Property(p => p.CreatedDate)
              .HasColumnName("CreatedDate")
              .IsRequired();

            //builder.Property(p => p.StartTime)
            //  .HasColumnName("StartTime")
            //  .IsRequired();

            //builder.Property(p => p.EndTime)
            //  .HasColumnName("EndTime")
            //  .IsRequired();

            builder.Property(p => p.IsFreeAccomodation)
              .HasColumnName("IsFreeAccomodation")
              .IsRequired();

            builder.Property(p => p.Deleted)
              .HasColumnName("Deleted")
              .IsRequired();
            #endregion

        }
    }
}
