using Location.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Location.Data.EntityTypeConfiguration
{
    public class LeaseEntityTypeConfiguration : IEntityTypeConfiguration<Lease>
    {
        public void Configure(EntityTypeBuilder<Lease> builder)
        {
        }
    }
}