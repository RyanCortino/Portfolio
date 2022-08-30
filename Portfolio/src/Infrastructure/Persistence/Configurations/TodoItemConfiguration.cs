using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Entities;

namespace Portfolio.Infrastructure.Persistence.Configurations;
public class TodoItemConfiguration : IEntityTypeConfiguration<TodoItem>
{
    public void Configure(EntityTypeBuilder<TodoItem> builder)
    {
        builder.Property(t => t.Title)
            .HasMaxLength(200)
            .IsRequired();
    }
}
