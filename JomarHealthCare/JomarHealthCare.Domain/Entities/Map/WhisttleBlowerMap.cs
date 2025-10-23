using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class WhisttleBlowerMap : IEntityTypeConfiguration<WhisttleBlower>
    {
        public void Configure(EntityTypeBuilder<WhisttleBlower> builder)
        {
            builder.ToTable("tbl_Whisttle_Blower");
            builder.HasKey(k => k.WhisttleBlowerId);

            #region Properties

            builder.Property(p => p.ClientName)
               .HasColumnName("ClientName")
               .HasMaxLength(256)
               .IsRequired();

            builder.Property(p => p.PersonReportingName)
               .HasColumnName("PersonReportingName")
               .HasMaxLength(256)
               .IsRequired();

            builder.Property(p => p.IncidentDate)
               .HasColumnName("IncidentDate")
               .IsRequired();

            builder.Property(p => p.IsThereWitness)
               .HasColumnName("IsThereWitness")
               .HasMaxLength(5);

            builder.Property(p => p.WitnessDetail)
               .HasColumnName("WitnessDetail");

            builder.Property(p => p.LikeCalling)
               .HasColumnName("LikeCalling")
               .HasMaxLength(5);

            builder.Property(p => p.PhoneNo)
               .HasColumnName("PhoneNo")
               .HasMaxLength(20);

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .HasMaxLength(20);

            builder.Property(p => p.Image)
               .HasColumnName("Image")
               .HasMaxLength(1024);

            builder.Property(p => p.CreatedBy)
               .HasColumnName("CreatedBy")
               .HasMaxLength(450);

            builder.Property(p => p.ReferenceNumber)
               .HasColumnName("ReferenceNumber")
               .HasMaxLength(50);

            builder.Property(p => p.NameOfHandlingPerson)
               .HasColumnName("NameOfHandlingPerson")
               .HasMaxLength(1024);

            builder.Property(p => p.NameOfHandlingPersonTel)
               .HasColumnName("NameOfHandlingPersonTel")
               .HasMaxLength(256);

            builder.Property(p => p.IncidentType)
               .HasColumnName("IncidentType")
               .HasMaxLength(20);
            #endregion
        }
    }
}