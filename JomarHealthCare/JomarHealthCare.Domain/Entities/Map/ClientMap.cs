using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("tbl_Client");
            builder.HasKey(k => k.ClientId);

            #region Properties
            builder.Property(p => p.CompanyId)
               .HasColumnName("CompanyId")
               .HasMaxLength(38);

            builder.Property(p => p.Firstname)
                .HasColumnName("Firstname")
                .HasMaxLength(128);

            builder.Property(p => p.Middlename)
               .HasColumnName("Middlename")
               .HasMaxLength(128);

            builder.Property(p => p.Surname)
               .HasColumnName("Surname")
               .HasMaxLength(128);

            builder.Property(p => p.PreferredName)
               .HasColumnName("PreferredName")
               .HasMaxLength(128);

            builder.Property(p => p.Email)
               .HasColumnName("Email")
               .HasMaxLength(128);

            builder.Property(p => p.About)
               .HasColumnName("About");

            builder.Property(p => p.Hobbies)
               .HasColumnName("Hobbies")
               .HasMaxLength(1024);

            builder.Property(p => p.Gender)
               .HasColumnName("Gender")
               .HasMaxLength(10);

            builder.Property(p => p.ServiceType)
               .HasColumnName("ServiceType")
               .HasMaxLength(50);

            builder.Property(p => p.Denture)
               .HasColumnName("Denture")
               .HasMaxLength(10);

            builder.Property(p => p.Aid)
               .HasColumnName("Aid")
               .HasMaxLength(10);

            builder.Property(p => p.Language)
               .HasColumnName("Language")
               .HasMaxLength(50);

            builder.Property(p => p.ChoiceOfStaff)
               .HasColumnName("ChoiceOfStaff")
               .HasMaxLength(20);

            builder.Property(p => p.Capacity)
               .HasColumnName("Capacity")
               .HasMaxLength(50);

            builder.Property(p => p.StartDate)
               .HasColumnName("StartDate");

            builder.Property(p => p.EndDate)
               .HasColumnName("EndDate");

            builder.Property(p => p.KeyworkerId)
               .HasColumnName("KeyworkerId")
               .HasMaxLength(50);

            builder.Property(p => p.IdNumber)
               .HasColumnName("IdNumber")
               .HasMaxLength(50);

            builder.Property(p => p.ProvisionVenue)
             .HasColumnName("ProvisionVenue")
             .HasMaxLength(512);

            builder.Property(p => p.PostCode)
               .HasColumnName("PostCode")
               .HasMaxLength(20);

            builder.Property(p => p.Rate)
               .HasColumnName("Rate")
               .HasColumnType("decimal(18,2)");

            builder.Property(p => p.TeamLeaderId)
             .HasColumnName("TeamLeader")
             .HasMaxLength(38);

            builder.Property(p => p.ClientManagerId)
             .HasColumnName("ClientManager")
             .HasMaxLength(38);

            builder.Property(p => p.Telephone)
               .HasColumnName("Telephone")
               .HasMaxLength(20);

            builder.Property(p => p.KeySafe)
              .HasColumnName("KeySafe")
              .HasMaxLength(50);

            builder.Property(p => p.ProviderReference)
            .HasColumnName("ProviderReference")
            .HasMaxLength(512);

            builder.Property(p => p.Pin)
              .HasColumnName("Pin")
              .HasMaxLength(10);

            builder.Property(p => p.UniqueId)
              .HasColumnName("UniqueId")
              .HasMaxLength(128);

            builder.Property(p => p.ProfileImage)
             .HasColumnName("ProfileImage")
             .HasMaxLength(512);

            builder.Property(p => p.Address)
            .HasColumnName("Address")
            .HasMaxLength(1024);

            builder.Property(p => p.Latitude)
            .HasColumnName("Latitude")
            .HasMaxLength(50);

            builder.Property(p => p.Longitude)
            .HasColumnName("Longitude")
            .HasMaxLength(50);


            builder.Property(p => p.LocationDistance)
             .HasColumnName("LocationDistance")
             .HasDefaultValue(0.01);

            builder.Property(p => p.PracticalSupport)
              .HasColumnName("PracticalSupport")
              .HasMaxLength(512);

            builder.Property(p => p.CallGap)
              .HasColumnName("CallGap")
              .HasMaxLength(10);

            #endregion

            builder.HasOne(client => client.AreaCode)
                .WithMany(area => area.Clients)
                .HasForeignKey(client => client.AreaCodeId)
                .IsRequired(false);

            builder.HasOne(client => client.Territory)
                .WithMany(area => area.Clients)
                .HasForeignKey(client => client.TeritoryId)
                .IsRequired(false);

            #region Relation
            #endregion
        }
    }
}
