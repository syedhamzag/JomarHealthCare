using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientKeyworkerNotesMap : IEntityTypeConfiguration<ClientKeyworkerNotes>
    {
        public void Configure(EntityTypeBuilder<ClientKeyworkerNotes> builder)
        {
            builder.ToTable("tbl_ClientKeyworkerNotes");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.KeyworkerId)
               .HasColumnName("KeyworkerId")
               .HasMaxLength(38);

            builder.Property(p => p.OtherStaffId)
               .HasColumnName("OtherStaffId")
               .HasMaxLength(38);
            #endregion
        }
    }
}
