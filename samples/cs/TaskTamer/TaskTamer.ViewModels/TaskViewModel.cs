using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using TaskTamer.DataLayer.Models;
using TaskTamer.DTOs;

namespace TaskTamer.ViewModels;

[TypeConverter(typeof(TaskViewModelTypeConverter))]
public partial class TaskViewModel : ObservableObject
{
    [ObservableProperty]
    private Guid _taskId;

    [ObservableProperty]
    private ProjectViewModel? _project;

    [ObservableProperty]
    private CategoryViewModel? _category;

    [ObservableProperty]
    private string _explanation = null!;

    [ObservableProperty]
    private string? _notes;

    [ObservableProperty]
    private UserViewModel? owner;

    [ObservableProperty]
    private DateTimeOffset? _startDate;

    [ObservableProperty]
    private DateTimeOffset? _dueDate;

    [ObservableProperty]
    private int _priority;

    [ObservableProperty]
    private int _percentDone;

    [ObservableProperty]
    private TaskItemStatus _status;

    [ObservableProperty]
    private string? _externalReference;

    // We need this for any ComboBox-Binding to work.
    public override bool Equals(object? obj)
        => obj is TaskViewModel other && TaskId == other.TaskId;

    override public string ToString() => Explanation;

    public TaskItem ToTaskItem()
    {
        return new TaskItem
        {
            TaskItemId = TaskId,
            Explanation = Explanation,
            Notes = Notes,
            Project = Project?.ToProject(),
            Category = Category?.ToCategory(),
            Owner = Owner!.ToUser(),
            DueDate = DueDate,
            StartDate = StartDate,
            Priority = Priority,
            PercentDone = PercentDone,
            Status = Status,
            ExternalReference = ExternalReference
        };
    }

    public static TaskViewModel FromTaskItem(TaskItem taskItem)
    {
        return new TaskViewModel
        {
            TaskId = taskItem.TaskItemId,
            Explanation = taskItem.Explanation,
            Notes = taskItem.Notes,
            Project = ProjectViewModel.FromProject(taskItem.Project),
            Category = CategoryViewModel.FromCategory(taskItem.Category),
            Owner = UserViewModel.FromUser(taskItem.Owner),
            DueDate = taskItem.DueDate,
            StartDate = taskItem.StartDate,
            Priority = taskItem.Priority,
            PercentDone = taskItem.PercentDone,
            Status = taskItem.Status,
            ExternalReference = taskItem.ExternalReference
        };
    }
}
