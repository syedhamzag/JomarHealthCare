using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PersonCentredMap : IEntityTypeConfiguration<PersonCentred>
    {
        public void Configure(EntityTypeBuilder<PersonCentred> builder)
        {
            builder.ToTable("tbl_PersonCentred");
            builder.HasKey(k => k.PersonCentredId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.ExpSupport)
             .HasColumnName("ExpSupport")
             .HasMaxLength(2048);

            builder.Property(p => p.Focus)
             .HasColumnName("Focus")
             .HasMaxLength(512);
            #endregion

            #region relationships
            builder.HasOne(p => p.Client)
                .WithMany(c => c.PersonCentred)
                .HasForeignKey(p => p.ClientId);
            #endregion


        }
    }
}
