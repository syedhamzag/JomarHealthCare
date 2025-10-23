using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HobbiesMap : IEntityTypeConfiguration<Hobbies>
    {
        public void Configure(EntityTypeBuilder<Hobbies> builder)
        {
            builder.ToTable("tbl_Hobbies");
            builder.HasKey(k => k.HId);

            #region Properties
            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .IsRequired();

            builder.Property(p => p.Description)
               .HasColumnName("Description")
               .IsRequired();

            builder.Property(p => p.CompanyId)
               .HasColumnName("CreatedBy")
               .HasMaxLength(450);
            #endregion
        }
    }
}
