using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ServiceWeekMap : IEntityTypeConfiguration<ServiceWeek>
    {
        public void Configure(EntityTypeBuilder<ServiceWeek> builder)
        {

            builder.ToTable("tbl_ServiceWeek");
            builder.HasKey(sw => sw.ServiceWeekId);
            // Set primary key
            //

            builder.Property(sw => sw.ServiceWeekId)
              .HasColumnName("ServiceWeekId")
              .IsRequired();
            // Set WeekName property as required and with maximum length of 50
            builder.Property(sw => sw.WeekName)
                .IsRequired()
                .HasMaxLength(50);


        }
    }
}
