using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map;

public class ClientSupportPlanMap : IEntityTypeConfiguration<ClientSupportPlan>
{
    public void Configure(EntityTypeBuilder<ClientSupportPlan> builder)
    {
        builder.ToTable("tbl_ClientSupportPlan");
        builder.HasKey(k => k.Id);

        #region Properties
        builder.Property(p => p.CompanyId)
           .HasColumnName("ClientId")
           .IsRequired();

        builder.Property(p => p.MentalHealth)
            .HasColumnName("MentalHealth")
            .IsRequired();

        builder.Property(p => p.SocialCareNeeds)
            .HasColumnName("SocialCareNeeds")
            .IsRequired();

        builder.Property(p => p.AccessCommunity)
            .HasColumnName("AccessCommunity")
            .IsRequired();

        builder.Property(p => p.Reltaionship)
            .HasColumnName("Reltaionship")
            .IsRequired();

        builder.Property(p => p.HabitateHomeEnvironment)
            .HasColumnName("HabitateHomeEnvironment")
            .IsRequired();

        builder.Property(p => p.PersonalHygiene)
            .HasColumnName("PersonalHygiene")
            .IsRequired();
        #endregion

        #region relationship


        #endregion
    }
}
