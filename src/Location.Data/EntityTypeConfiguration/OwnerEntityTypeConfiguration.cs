using Location.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Location.Data.EntityTypeConfiguration
{
    public class OwnerEntityTypeConfiguration : IEntityTypeConfiguration<Owner>
    {
    public void Configure(EntityTypeBuilder<Owner> builder)
    {
    }
    }
}