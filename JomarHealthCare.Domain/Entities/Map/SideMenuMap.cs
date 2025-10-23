using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class SideMenuMap : IEntityTypeConfiguration<SideMenu>
    {
        public void Configure(EntityTypeBuilder<SideMenu> builder)
        {
            builder.ToTable("tbl_SideMenu");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .HasMaxLength(256);

            builder.Property(p => p.ControllerName)
               .HasColumnName("ControllerName")
               .HasMaxLength(256);

            builder.Property(p => p.ActionName)
               .HasColumnName("ActionName")
               .HasMaxLength(256);

            builder.Property(p => p.Icon)
               .HasColumnName("Icon")
               .HasMaxLength(256);

            builder.Property(p => p.parentsId)
               .HasColumnName("parentsId");

			builder.Property(p => p.IsActive)
               .HasColumnName("IsActive");

			builder.Property(p => p.Level)
			   .HasColumnName("Level");

			#endregion
		}
	}
}
