using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PersonalHygieneMap : IEntityTypeConfiguration<PersonalHygiene>
    {
        public void Configure(EntityTypeBuilder<PersonalHygiene> builder)
        {
            builder.ToTable("tbl_PersonalHygiene");
            builder.HasKey(k => k.HygieneId);

            #region Properties

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.LaundryGuide)
               .HasColumnName("LaundryGuide")
               .HasMaxLength(1024);

            builder.Property(p => p.LaundrySupport)
                .HasColumnName("LaundrySupport")
                .HasMaxLength(1024);
            #endregion

            #region Relationship
            // builder.HasOne(p => p.Client)
            //      .WithMany(p => p.PersonalHygiene)
            //      .HasForeignKey(p => p.CompanyId)
            //      .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
