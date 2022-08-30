using Portfolio.Application.Common.Mappings;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.TodoLists.Queries.ExportTodos;
public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
