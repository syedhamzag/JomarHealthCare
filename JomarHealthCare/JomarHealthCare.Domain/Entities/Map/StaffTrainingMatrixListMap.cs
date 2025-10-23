using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    class StaffTrainingMatrixListMap : IEntityTypeConfiguration<StaffTrainingMatrixList>
    {
        public void Configure(EntityTypeBuilder<StaffTrainingMatrixList> builder)
        {
            builder.ToTable("tbl_StaffTrainingMatrixList");
            builder.HasKey(p => p.TrainingId);

            #region Properties
            builder.Property(p => p.MatrixId)
                .HasColumnName("MatrixId")
                .IsRequired();

            builder.Property(p => p.Date)
                .HasColumnName("Date")
                .IsRequired();
            #endregion
        }
    }
}
