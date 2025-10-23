using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class RotaTaskMap : IEntityTypeConfiguration<RotaTask>
    {
        public void Configure(EntityTypeBuilder<RotaTask> builder)
        {
            builder.ToTable("tbl_RotaTask");
            builder.HasKey(p => p.RotaTaskId);

            #region Properties
            builder.Property(p => p.RotaTaskId)
                .HasColumnName("RotaTaskId")
                .IsRequired();

            builder.Property(p => p.TaskName)
                .HasColumnName("TaskName")
                .HasMaxLength(125);

            builder.Property(p => p.GivenAcronym)
              .HasColumnName("GivenAcronym")
              .HasMaxLength(50);

            builder.Property(p => p.NotGivenAcronym)
             .HasColumnName("NotGivenAcronym")
             .HasMaxLength(50);

            builder.Property(p => p.Remark)
             .HasColumnName("Remark")
             .HasMaxLength(38);

            builder.Property(p => p.CompanyId)
            .HasColumnName("CompanyId")
            .HasMaxLength(38);
            #endregion
        }
    }
}
