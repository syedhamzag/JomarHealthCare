using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientProgramMap : IEntityTypeConfiguration<ClientProgram>
    {
        public void Configure(EntityTypeBuilder<ClientProgram> builder)
        {
            builder.ToTable("tbl_Client_Program");
            builder.HasKey(k => k.ProgramId);

            #region Properties
            builder.Property(p => p.Reference)
               .HasColumnName("Reference")
               .IsRequired();

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Remarks)
               .HasColumnName("Remarks")
               .HasMaxLength(2024);

            builder.Property(p => p.Observation)
             .HasColumnName("Observation")
             .HasMaxLength(2024);

            builder.Property(p => p.ActionRequired)
             .HasColumnName("ActionRequired")
             .HasMaxLength(2024);

            builder.Property(p => p.URL)
             .HasColumnName("URL")
             .HasMaxLength(1024);

            builder.Property(p => p.Attachment)
             .HasColumnName("Attachment")
             .HasMaxLength(1024);
            #endregion

            #region Relationship
            // builder.HasOne(p => p.Client)
            //      .WithMany(p => p.ClientProgram)
            //      .HasForeignKey(p => p.CompanyId)
            //      .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<ProgramOfficerToAct>(p => p.OfficerToAct)
            //    .WithOne(p => p.Program)
            //    .HasForeignKey(p => p.ProgramId)
            //    .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
