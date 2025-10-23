using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientCareObjMap : IEntityTypeConfiguration<ClientCareObj>
    {
        public void Configure(EntityTypeBuilder<ClientCareObj> builder)
        {
            builder.ToTable("tbl_ClientCareObj");
            builder.HasKey(k => k.CareObjId);

            #region Properties
            builder.Property(p => p.CompanyId)
               .HasColumnName("ClientId")
               .IsRequired();

            builder.Property(p => p.Date)
               .HasColumnName("Date")
               .IsRequired();

            builder.Property(p => p.Note)
               .HasColumnName("Note")
               .IsRequired();

            builder.Property(p => p.Remark)
               .HasColumnName("Remark")
               .IsRequired();

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .IsRequired();
            #endregion

            #region Relationship
            // builder.HasOne(p => p.Client)
            //      .WithMany(p => p.ClientCareObj)
            //      .HasForeignKey(p => p.CompanyId)
            //      .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<CareObjPersonToAct>(p => p.PersonToAct)
                .WithOne(p => p.ClientCareObj)
                .HasForeignKey(p => p.CareObjId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
