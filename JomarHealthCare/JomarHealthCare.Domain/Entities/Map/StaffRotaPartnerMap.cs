using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffRotaPartnerMap : IEntityTypeConfiguration<StaffRotaPartner>
    {
        public void Configure(EntityTypeBuilder<StaffRotaPartner> builder)
        {
            builder.ToTable("tbl_StaffRotaPartner");
            builder.HasKey(k => k.StaffRotaPartnerId);

            #region Properties
            builder.Property(p => p.StaffId)
               .HasColumnName("StaffId")
               .HasMaxLength(38);
            #endregion

            #region Relationship
            builder.HasOne(r => r.StaffRota)
                .WithMany(m => m.StaffRotaPartners)
                .HasForeignKey(f => f.StaffRotaId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
