using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class RoleMap : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var roles = new List<IdentityRole>
            {
                new IdentityRole
               {
                   ConcurrencyStamp = "32a5a6e8-0ade-45fb-a751-f469e975b66d",
                   Name = AppRole.SuperAdmin.ToString(),
                   NormalizedName = AppRole.SuperAdmin.ToString().ToUpperInvariant(),
                   Id = "93be1e09-c686-4bb2-8e1b-8594f5585dd9"
               },
                 new IdentityRole
               {
                   ConcurrencyStamp = "2fca74f5-8568-4b34-ac21-5b8a91de0372",
                   Name = AppRole.Company.ToString(),
                   NormalizedName = AppRole.Company.ToString().ToUpperInvariant(),
                   Id = "acac7fb6-7c4a-4da8-a22e-47caab9928a9"
               },
                 new IdentityRole
               {
                   ConcurrencyStamp = "d8c9e243-4f54-4b1f-9d1b-6449cb907522",
                   Name = AppRole.Staff.ToString(),
                   NormalizedName = AppRole.Staff.ToString().ToUpperInvariant(),
                   Id = "3d2c49d5-639c-4e86-abd1-c7da88561541"
               }
            };

            builder.HasData(roles);
        }
    }
}
