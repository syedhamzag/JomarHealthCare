using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    internal class FeedBackMatchingWordsMap : IEntityTypeConfiguration<FeedBackMatchingWords>
    {
        public void Configure(EntityTypeBuilder<FeedBackMatchingWords> builder)
        {
            builder.ToTable("tbl_FeedBackMatchingWords");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
            .HasColumnName("Name")
            .HasMaxLength(512);
        }
    }
}
