using MediatR;

namespace Portfolio.Domain.Entities;

public class WorkExperience
{
    public string Name { get; init; }
    public string Location;
    public string Dates;
    public string JobTitle;

    public string[] Responsibilities;
    public string[] Skills;
    public string[] Strengths;
}
