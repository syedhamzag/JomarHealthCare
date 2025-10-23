using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientRotaMap : IEntityTypeConfiguration<ClientRota>
    {
        public void Configure(EntityTypeBuilder<ClientRota> builder)
        {
            builder.ToTable("tbl_ClientRota");
            builder.HasKey(p => p.ClientRotaId);

            #region Properties
            builder.Property(p => p.ClientRotaId)
                .HasColumnName("ClientRotaId")
                .IsRequired();

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.ClientRotaTypeId)
               .HasColumnName("ClientRotaTypeId")
               .IsRequired();
            #endregion

            #region Relationship
          
            builder.HasOne(p => p.ClientRotaType)
                .WithMany(p => p.ClientRota)
                .HasForeignKey(p => p.ClientRotaTypeId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
