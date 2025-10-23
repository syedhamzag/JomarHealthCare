using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientHobbiesMap : IEntityTypeConfiguration<ClientHobbies>
    {
        public void Configure(EntityTypeBuilder<ClientHobbies> builder)
        {
            builder.ToTable("tbl_ClientHobbies");
            builder.HasKey(k => k.CHId);

            #region Properties
            builder.Property(p => p.HId)
               .HasColumnName("HId")
               .IsRequired();

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);
            #endregion

            #region Relation
            builder.HasOne(p => p.Client)
                 .WithMany(p => p.ClientHobbies)
                 .HasForeignKey(p => p.ClientId);

            builder.HasOne(p => p.Hobbies)
             .WithMany(p => p.ClientHobbies)
             .HasForeignKey(p => p.HId);

            #endregion
        }
    }
}
