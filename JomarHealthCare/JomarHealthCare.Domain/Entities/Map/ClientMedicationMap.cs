using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientMedicationMap : IEntityTypeConfiguration<ClientMedication>
    {
        public void Configure(EntityTypeBuilder<ClientMedication> builder)
        {
            builder.ToTable("tbl_ClientMedication");
            builder.HasKey(k => k.ClientMedicationId);

            #region Properties
            builder.Property(p => p.ClientMedicationId)
                .HasColumnName("ClientMedicationId")
                .IsRequired();

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);


            builder.Property(p => p.Dossage)
               .HasColumnName("Dossage")
               .HasMaxLength(50);

            builder.Property(p => p.Frequency)
               .HasColumnName("Frequency")
               .HasMaxLength(50);


            builder.Property(p => p.Route)
               .HasColumnName("Route")
               .HasMaxLength(50);

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .HasMaxLength(50);

            builder.Property(p => p.Remark)
               .HasColumnName("Remark")
               .HasMaxLength(1024);

            builder.Property(p => p.ClientMedImage)
               .HasColumnName("ClientMedImage")
               .HasMaxLength(1024);

            builder.Property(p => p.PRNGuideline)
               .HasColumnName("PRNGuideline")
               .HasMaxLength(1024);
            #endregion

            #region Relationship

            builder.HasOne(c => c.Client)
                .WithMany(c => c.ClientMedication)
                .HasForeignKey(k => k.ClientId);
            #endregion
        }
    }
}
