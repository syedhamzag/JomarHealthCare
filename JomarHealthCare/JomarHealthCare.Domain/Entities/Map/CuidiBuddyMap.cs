using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CuidiBuddyMap : IEntityTypeConfiguration<CuidiBuddy>
    {
        public void Configure(EntityTypeBuilder<CuidiBuddy> builder)
        {
            builder.ToTable("tbl_CuidiBuddy");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.CuidiBuddyId)
               .HasColumnName("CuidiBuddyId")
               .IsRequired();

            builder.Property(p => p.CompanyId)
               .HasColumnName("ClientId")
               .IsRequired();
            #endregion

            #region Relation
            // builder.HasOne(p => p.Client)
            //      .WithMany(p => p.CuidiBuddy)
            //      .HasForeignKey(p => p.CompanyId)
            //      .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
