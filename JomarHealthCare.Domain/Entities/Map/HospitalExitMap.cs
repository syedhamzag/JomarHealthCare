using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HospitalExitMap : IEntityTypeConfiguration<HospitalExit>
    {
        public void Configure(EntityTypeBuilder<HospitalExit> builder)
        {
            builder.ToTable("tbl_HospitalExit");
            builder.HasKey(k => k.HospitalExitId);

            #region Properties

            builder.Property(p => p.Reference)
               .HasColumnName("Reference")
               .HasMaxLength(256);

            builder.Property(p => p.ClientId)
                .HasColumnName("ClientId")
                .HasMaxLength(38);


            builder.Property(p => p.WhichSupportIsNeeded)
                .HasColumnName("WhichSupportIsNeeded")
                .HasMaxLength(1024);

            builder.Property(p => p.Remark)
                .HasColumnName("Remark")
                .HasMaxLength(2048);

            #endregion

            #region Relationship
            //builder.HasMany<HospitalExitOfficerToTakeAction>(p => p.OfficerToTakeAction)
            //    .WithOne(p => p.HospitalExit)
            //    .HasForeignKey(p => p.HospitalExitId)
            //    .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
