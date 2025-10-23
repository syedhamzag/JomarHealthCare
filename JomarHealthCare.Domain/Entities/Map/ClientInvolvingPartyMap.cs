using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientInvolvingPartyMap : IEntityTypeConfiguration<ClientInvolvingParty>
    {
        public void Configure(EntityTypeBuilder<ClientInvolvingParty> builder)
        {
            builder.ToTable("tbl_ClientInvolvingParty");
            builder.HasKey(p => p.ClientInvolvingPartyId);

            #region Properties

            builder.Property(p => p.ClientInvolvingPartyItem)
                .HasColumnName("ClientInvolvingPartyItem")
                .HasMaxLength(50);

            builder.Property(p => p.ClientId)
                 .HasColumnName("ClientId")
                 .HasMaxLength(38);

            builder.Property(p => p.Name)
                 .HasColumnName("Name")
                 .HasMaxLength(50);

            builder.Property(p => p.Address)
                .HasColumnName("Address")
                .HasMaxLength(225);

            builder.Property(p => p.Email)
               .HasColumnName("Email")
               .HasMaxLength(125);

            builder.Property(p => p.Telephone)
               .HasColumnName("Telephone")
               .HasMaxLength(20);

            builder.Property(p => p.Relationship)
              .HasColumnName("Relationship")
              .HasMaxLength(50);

            #endregion

            #region Relation
            builder.HasOne(p => p.Client)
                 .WithMany(p => p.InvolvingParties)
                 .HasForeignKey(p => p.ClientId);
            #endregion
        }
    }
}
