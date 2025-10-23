using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ComplainRegistorClientsMap : IEntityTypeConfiguration<ComplainRegistorClients>
    {
        public void Configure(EntityTypeBuilder<ComplainRegistorClients> builder)
        {
            builder.ToTable("tbl_ComplainRegistorClients");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.ComplainRegistorId)
               .HasColumnName("ComplainRegistorId");
            #endregion

            #region Relationship
            builder.HasOne(p => p.ComplainRegistor)
             .WithMany(p => p.ComplainRegistorClients)
             .HasForeignKey(p => p.ComplainRegistorId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Client)
             .WithMany(p => p.ComplainRegistorClients)
             .HasForeignKey(p => p.ClientId)
             .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
