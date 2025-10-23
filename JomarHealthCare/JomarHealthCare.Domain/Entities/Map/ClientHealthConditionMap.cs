using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientHealthConditionMap : IEntityTypeConfiguration<ClientHealthCondition>
    {
        public void Configure(EntityTypeBuilder<ClientHealthCondition> builder)
        {
            builder.ToTable("tbl_ClientHealthCondition");
            builder.HasKey(k => k.CHCId);

            #region Properties

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);
            #endregion

            #region Relation
            builder.HasOne(p => p.Client)
                 .WithMany(p => p.ClientHealthCondition)
                 .HasForeignKey(p => p.ClientId);
            #endregion
        }
    }
}
