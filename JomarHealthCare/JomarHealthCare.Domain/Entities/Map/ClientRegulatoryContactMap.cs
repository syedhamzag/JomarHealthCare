using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientRegulatoryContactMap : IEntityTypeConfiguration<ClientRegulatoryContact>
    {
        public void Configure(EntityTypeBuilder<ClientRegulatoryContact> builder)
        {
            builder.ToTable("tbl_ClientRegulatoryContact");
            builder.HasKey(p => p.ClientRegulatoryContactId);

            #region Properties
            builder.Property(p => p.ClientRegulatoryContactId)
                .HasColumnName("ClientRegulatoryContactId")
                .IsRequired();

            builder.Property(p => p.ClientId)
              .HasColumnName("ClientId")
              .IsRequired();

            builder.Property(p => p.BaseRecordItemId)
              .HasColumnName("BaseRecordItemId")
              .IsRequired();

            builder.Property(p => p.DatePerformed)
                .HasColumnName("DatePerformed")
                .HasColumnType("datetime2")
                .IsRequired(false);

            builder.Property(p => p.DueDate)
               .HasColumnName("DueDate")
               .HasColumnType("datetime2")
               .IsRequired(false);

            builder.Property(p => p.Evidence)
                .HasColumnName("Evidence")
                .IsRequired(false);
            #endregion
        }
    }
}
