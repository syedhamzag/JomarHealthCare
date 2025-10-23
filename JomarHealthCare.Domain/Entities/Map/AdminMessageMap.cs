using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class AdminMessageMap : IEntityTypeConfiguration<AdminMessage>
    {
        public void Configure(EntityTypeBuilder<AdminMessage> builder)
        {
            builder.ToTable("tbl_AdminMessage");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.AdminsMessage)
               .HasColumnName("AdminsMessage")
               .HasMaxLength(1025)
               .IsRequired(true);

            builder.Property(p => p.IsForAll)
               .HasColumnName("IsForAll")
               .IsRequired();

            builder.Property(p => p.CreatedDate)
               .HasColumnName("CreatedDate")
               .IsRequired();


            #endregion
        }
    }

}
