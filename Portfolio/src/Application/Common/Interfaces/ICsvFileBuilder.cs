using Portfolio.Application.TodoLists.Queries.ExportTodos;

namespace Portfolio.Application.Common.Interfaces;
public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
