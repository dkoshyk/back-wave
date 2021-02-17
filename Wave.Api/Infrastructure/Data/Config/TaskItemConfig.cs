using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wave.Api.ApplicationCore;

namespace Wave.Api.Infrastructure.Data.Config
{
    public class TaskItemConfig : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.ToTable("Tasks");

            builder.Property(e => e.Title)
                .IsRequired();

            //builder.HasData(SeedData.Authors());
        }
    }
}
