namespace TaskTamer.DataLayer.Models;

public partial class Project
{
    private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    private static readonly Random s_random = new();
    private static readonly string[] s_statuses =
    [
        "Not Started",
        "In Progress",
        "On Hold",
        "Completed"
    ];

    /// <summary>
    /// Generates sample Project data.
    /// </summary>
    /// <param name="context">The TimeTamerContext instance.</param>
    /// <remarks>
    /// This method generates sample Project data including the Projects "WinForms Classic Designer", "WinForms OOP-Designer", "WinForms Runtime", "WinForms Async", "WinForms DarkMode", "Copilot conceptional work", "Prototyping", "CommToolkit work".
    /// </remarks>
    public static void EnsureSampleProjectsData(TaskTamerContext context, User user)
    {
        // Do we have Project sample data?
        if (context.Projects.Any())
        {
            return;
        }

        // Get the first Category as the default:
        var categories = context.Categories.ToArray();

        var projects = new List<Project>
        {
            CreateProject("WinForms Designer 17.13 Preview 1", " ", user),
            CreateProject("Writing ADHD Book", " ", user),
            CreateProject("Servicing .NET 9", " ", user),
            CreateProject("New .NET 10 APIs", " ", user),
            CreateProject("WinForms Community Toolkit", " ", user),
            CreateProject("Security Analyzers", " ", user),
        };

        context.Projects.AddRange(projects);
        context.SaveChanges();
    }

    private static Project CreateProject(string name, string description, User owner)
    {
        var now = DateTimeOffset.Now;
        var startDate = now.AddDays(-s_random.Next(1, 15)).AddHours(s_random.Next(24));
        var endDate = now.AddDays(s_random.Next(15, 30)).AddHours(s_random.Next(24));

        return new Project
        {
            ProjectId = Guid.NewGuid(),
            Name = name,
            Description = description,
            StartDate = startDate,
            EndDate = endDate,
            Owner = owner,
            Status = GenerateRandomProjectStatus(),
            ExternalReference = GenerateExternalReference(),
            DateCreated = now,
            DateLastModified = now,
            SyncId = Guid.NewGuid()
        };
    }

    private static string GenerateRandomProjectStatus() 
        => s_statuses[s_random.Next(s_statuses.Length)];

    private static string GenerateExternalReference() 
        => new(Enumerable
            .Repeat(Chars, 6)
            .Select(s => s[s_random.Next(s.Length)])
            .ToArray());
}
