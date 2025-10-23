using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PersonCentredFocusMap : IEntityTypeConfiguration<PersonCentredFocus>
    {
        public void Configure(EntityTypeBuilder<PersonCentredFocus> builder)
        {
            builder.ToTable("tbl_PersonCentredFocus");
            builder.HasKey(k => k.PersonCentredFocusId);

            #region Properties

            builder.Property(p => p.PersonCentredFocusId)
               .HasColumnName("PersonCentredFocusId")
               .IsRequired();

            builder.Property(p => p.BaseRecordId)
               .HasColumnName("BaseRecordId")
               .IsRequired();

            builder.Property(p => p.PersonCentredId)
               .HasColumnName("PersonCentredId")
               .IsRequired();

            #endregion
        }
    }
}
