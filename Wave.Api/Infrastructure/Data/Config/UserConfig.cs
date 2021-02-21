using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wave.Api.ApplicationCore;

namespace Wave.Api.Infrastructure.Data.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.Property(e => e.Login)
                .IsRequired();

            builder.Property(e => e.Password)
                .IsRequired();

            builder.HasData(SeedData.Users());
        }
    }
}
