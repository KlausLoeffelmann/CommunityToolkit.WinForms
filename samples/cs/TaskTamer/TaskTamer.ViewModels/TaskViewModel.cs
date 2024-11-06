using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using TaskTamer.DataLayer.Models;
using TaskTamer.DTOs;

namespace TaskTamer.ViewModels;

[TypeConverter(typeof(TaskViewModelTypeConverter))]
public partial class TaskViewModel : ObservableObject
{
    public TaskViewModel()
    {
        _dateCreated = DateTimeOffset.Now;
        _dateModified = DateTimeOffset.Now;
    }

    [ObservableProperty]
    private Guid _taskId;

    [ObservableProperty]
    private ProjectViewModel? _project;

    [ObservableProperty]
    private CategoryViewModel? _category;

    [ObservableProperty]
    private string _description = null!;

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
    private string? _systemLog;

    [ObservableProperty]
    private string? _externalReference;

    [ObservableProperty]
    private DateTimeOffset _dateCreated;

    [ObservableProperty]
    private DateTimeOffset _dateModified;

    // We need this for any ComboBox-Binding to work.
    public override bool Equals(object? obj)
        => obj is TaskViewModel other && TaskId == other.TaskId;

    public override int GetHashCode()
        => TaskId.GetHashCode();

    override public string ToString() => Description;

    public TaskItem ToTaskItem() 
        => new()
        {
            TaskItemId = TaskId,
            Description = Description,
            Notes = Notes,
            Project = Project?.ToProject(),
            Category = Category?.ToCategory(),
            Owner = Owner!.ToUser(),
            DueDate = DueDate,
            StartDate = StartDate,
            Priority = Priority,
            PercentDone = PercentDone,
            Status = Status,
            ExternalReference = ExternalReference,
            DateCreated = DateCreated,
            DateModified = DateModified,
            SystemLog = SystemLog
        };

    public static TaskViewModel FromTaskItem(TaskItem taskItem) 
        => new()
        {
            TaskId = taskItem.TaskItemId,
            Description = taskItem.Description,
            Notes = taskItem.Notes,
            Project = ProjectViewModel.FromProject(taskItem.Project),
            Category = CategoryViewModel.FromCategory(taskItem.Category),
            Owner = UserViewModel.FromUser(taskItem.Owner),
            DueDate = taskItem.DueDate,
            StartDate = taskItem.StartDate,
            Priority = taskItem.Priority,
            PercentDone = taskItem.PercentDone,
            Status = taskItem.Status,
            ExternalReference = taskItem.ExternalReference,
            DateCreated = taskItem.DateCreated,
            DateModified = taskItem.DateModified,
            SystemLog = taskItem.SystemLog
        };
}
