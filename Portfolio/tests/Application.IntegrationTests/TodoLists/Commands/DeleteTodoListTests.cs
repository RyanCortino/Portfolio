using FluentAssertions;
using NUnit.Framework;
using Portfolio.Application.Common.Exceptions;
using Portfolio.Application.TodoLists.Commands.CreateTodoList;
using Portfolio.Application.TodoLists.Commands.DeleteTodoList;
using Portfolio.Domain.Entities;

using static Portfolio.Application.IntegrationTests.Testing;

namespace Portfolio.Application.IntegrationTests.TodoLists.Commands;
public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
