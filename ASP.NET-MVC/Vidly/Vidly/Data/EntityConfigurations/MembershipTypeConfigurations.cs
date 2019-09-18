using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vidly.Models;

namespace Vidly.Data.EntityConfigurations
{
    public class MembershipTypeConfigurations : IEntityTypeConfiguration<MembershipType>
    {
        public void Configure(EntityTypeBuilder<MembershipType> builder)
        {
            builder.HasOne(a => a.Customer)
                .WithOne(b => b.MembershipType)
                .HasForeignKey<Customer>(c => c.MembershipTypeId);
        }
    }
}