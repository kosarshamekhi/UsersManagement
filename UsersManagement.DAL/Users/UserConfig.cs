using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsersManagement.Model.Users;

namespace UsersManagement.DAL.Users;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.FirstName).IsRequired().HasMaxLength(128);
        builder.Property(c => c.LastName).HasMaxLength(128);
        builder.Property(c => c.Email).IsRequired();
        builder.Property(c => c.Age).IsRequired().HasMaxLength(128);
    }
}
