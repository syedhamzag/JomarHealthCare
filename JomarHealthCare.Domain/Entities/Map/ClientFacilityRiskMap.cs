using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map;

public class ClientFacilityRiskMap : IEntityTypeConfiguration<ClientFacilityRisk>
{
    public void Configure(EntityTypeBuilder<ClientFacilityRisk> builder)
    {
        builder.ToTable("tbl_ClientFacilityRisk");
        builder.HasKey(k => k.Id);

        builder.HasOne(p => p.ClientFacility)
         .WithMany(p => p.ClientFacilityRisk)
        .HasForeignKey(p => p.FacilityClientId)
        .OnDelete(DeleteBehavior.Cascade);
    }

}
