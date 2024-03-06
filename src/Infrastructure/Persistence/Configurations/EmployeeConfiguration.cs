using Domain.Consts;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasIndex(e => e.EmployeeId).IsUnique();
            builder.HasKey(e => e.EmployeeId);
            builder.Property(e => e.Name).HasMaxLength(TableConsts.MaxStringLength);
            builder.Property(e => e.Surname).HasMaxLength(TableConsts.MaxStringLength);
            builder.Property(e => e.Email).HasMaxLength(TableConsts.MaxStringLength);
            builder.Property(e => e.PhoneNumber).HasMaxLength(TableConsts.MaxStringLength);
        }
    }
}
