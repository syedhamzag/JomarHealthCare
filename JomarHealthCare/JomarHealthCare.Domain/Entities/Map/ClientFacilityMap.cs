using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientFacilityMap : IEntityTypeConfiguration<ClientFacility>
    {
        public void Configure(EntityTypeBuilder<ClientFacility> builder)
        {
            builder.ToTable("tbl_ClientFacility");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Name)
            .HasColumnName("Name")
            .HasMaxLength(450);

            builder.Property(p => p.RegistrationType)
            .HasColumnName("RegistrationType")
            .HasMaxLength(450);

            builder.Property(p => p.Address)
            .HasColumnName("Address")
            .HasMaxLength(450);

            builder.Property(p => p.PhoneNumber)
            .HasColumnName("PhoneNumber")
            .HasMaxLength(450);

            builder.Property(p => p.Email)
            .HasColumnName("Email")
            .HasMaxLength(450);

            builder.Property(p => p.WebsiteUrl)
            .HasColumnName("Website")
            .HasMaxLength(450);

            builder.Property(p => p.BusinessType)
            .HasColumnName("BusinessType");

            builder.Property(p => p.FacilityManagerName)
            .HasColumnName("FacilityManagerName")
            .HasMaxLength(450);

            builder.Property(p => p.FacilityManagerPhoneNumber)
            .HasColumnName("FacilityManagerPhoneNumber")
            .HasMaxLength(450);

            builder.Property(p => p.NumberOfRooms)
            .HasColumnName("NumberOfRooms");

            builder.Property(p => p.FacilityType)
            .HasColumnName("FacilityType")
            .HasMaxLength(450);

            builder.Property(p => p.Description)
            .HasColumnName("Description")
            .HasMaxLength(450);

            builder.Property(p => p.CreatedBy)
            .HasColumnName("CreatedBy")
            .HasMaxLength(450);

            builder.Property(p => p.IsActive)
             .HasColumnName("IsActive")
             .IsRequired();

            builder.Property(p => p.Deleted)
             .HasColumnName("Deleted")
             .IsRequired();

            builder.Property(p => p.CreatedDate)
              .HasColumnName("CreatedDate")
              .IsRequired();

            builder.Property(p => p.Profile)
              .HasColumnName("Profile")
              .HasMaxLength(1024);

            builder.Property(p => p.ServiceObjective)
              .HasColumnName("ServiceObjective")
              .HasMaxLength(2000);

            builder.Property(p => p.AccessCodeNumber)
              .HasColumnName("AccessCodeNumber")
              .HasMaxLength(100);

            builder.Property(p => p.Latitude)
              .HasColumnName("Latitude")
              .HasMaxLength(100);

            builder.Property(p => p.Longitude)
              .HasColumnName("Longitude")
              .HasMaxLength(100);

            builder.Property(p => p.AboutClient)
              .HasColumnName("AboutClient")
              .HasMaxLength(2000);

            builder.Property(p => p.IdNumber)
              .HasColumnName("IdNumber")
              .HasMaxLength(50);

            #region relationship
            #endregion
        }
    }
}
