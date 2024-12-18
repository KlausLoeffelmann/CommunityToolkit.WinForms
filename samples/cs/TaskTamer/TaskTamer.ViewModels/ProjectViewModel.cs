﻿using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using TaskTamer.DataLayer.Models;

namespace TaskTamer.ViewModels;

public partial class ProjectViewModel : ObservableObject
{
    [ObservableProperty]
    private Guid _projectId;

    [ObservableProperty]
    private string _name = default!;

    [ObservableProperty]
    private string? _description;

    [ObservableProperty]
    private CategoryViewModel _category = default!;

    [ObservableProperty]
    private DateTimeOffset? _startDate;

    [ObservableProperty]
    private DateTimeOffset? _endDate;

    [ObservableProperty]
    private UserViewModel? _owner;

    [ObservableProperty]
    private string? _status;

    public Project ToProject() 
        => new Project
        {
            ProjectId = ProjectId,
            Name = Name,
            Description = Description,
            StartDate = StartDate,
            EndDate = EndDate,
            Owner = Owner?.ToUser(),
            Status = Status
        };

    // We need this for any ComboBox-Binding to work.
    public override bool Equals(object? obj)
        => obj is ProjectViewModel other && ProjectId == other.ProjectId;

    public override string ToString()
        => $"{Name} ({Category})";

    public static ProjectViewModel? FromProject(Project? project)
    {
        if (project is null)
        {
            return null;
        }

        return new ProjectViewModel
        {
            ProjectId = project.ProjectId,
            Name = project.Name,
            Description = project.Description,
            Owner = UserViewModel.FromUser(project.Owner),
            StartDate = project.StartDate,
            EndDate = project.EndDate,
            Status = project.Status
        };
    }

    public static ObservableCollection<ProjectViewModel> GetActive()
    {
        var projectViewModels = Project
            .GetActiveProjects()
            .ToViewModels();

        return projectViewModels;
    }
}
