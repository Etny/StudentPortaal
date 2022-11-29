

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortaalBackend.Domain.Models.Joins;

namespace PortaalBackend.Business.Infrastructure.Configuration
{
    public class AssignmentTagConfiguration : IEntityTypeConfiguration<AssignmentTag>
    {
        public void Configure(EntityTypeBuilder<AssignmentTag> builder)
        {
            builder.HasKey(at => new { at.AssignmentId, at.TagId });

            builder
                .HasOne(at => at.Assignment)
                .WithMany(a => a.AssignmentTags)
                .HasForeignKey(at => at.AssignmentId);

            builder
                .HasOne(at => at.Tag)
                .WithMany(t => t.AssignmentTags)
                .HasForeignKey(at => at.TagId);
        }
    }
}