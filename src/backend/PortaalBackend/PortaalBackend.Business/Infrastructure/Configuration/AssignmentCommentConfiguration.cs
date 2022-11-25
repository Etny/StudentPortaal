
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortaalBackend.Domain.Models.Joins;

namespace PortaalBackend.Business.Infrastructure.Configuration
{
    public class AssignmentCommentConfiguration : IEntityTypeConfiguration<AssignmentComment>
    {
        public void Configure(EntityTypeBuilder<AssignmentComment> builder)
        {
            builder.HasKey(at => new { at.AssignmentId, at.CommentId });

            builder
                .HasOne(ac => ac.Assignment)
                .WithMany(a => a.AssignmentComments)
                .HasForeignKey(ac => ac.AssignmentId);

            builder
                .HasOne(ac => ac.Comment)
                .WithMany(t => t.AssignmentComments)
                .HasForeignKey(ac => ac.CommentId);
        }
    }
}