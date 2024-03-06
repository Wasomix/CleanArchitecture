using Domain.Consts;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasIndex(e => e.AddressId).IsUnique();
            builder.Property(e => e.Street).HasMaxLength(TableConsts.MaxStringLength);
            builder.Property(e => e.City).HasMaxLength(TableConsts.MaxStringLength);
            builder.Property(e => e.PostalCode).HasMaxLength(TableConsts.MaxStringLength);
            builder.Property(e => e.Country).HasMaxLength(TableConsts.MaxStringLength);
        }
    }
}
