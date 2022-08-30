using Portfolio.Application.Common.Interfaces;

namespace Portfolio.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
