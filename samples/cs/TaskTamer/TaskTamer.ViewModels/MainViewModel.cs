﻿using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Diagnostics;
using TaskTamer.DataLayer.Models;

namespace TaskTamer.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        InitViewModel();

        CurrentUser = UserViewModel.FromUser(User.GetCurrentUser());
        Projects = ProjectViewModel.GetActive();
        Categories = CategoryViewModel.GetCategories();
        IsTimerRunning = true;
    }

    /// <summary>
    ///  Property, which will be bound to a StatusStrip label in the MainView, showing the current time.
    /// </summary>
    [ObservableProperty]
    private string _currentDisplayTime = default!;

    [ObservableProperty]
    private bool _isTimerRunning;

    /// <summary>
    ///  Property, which will be bound to a StatusStrip label in the MainView, showing the current user's name.
    /// </summary>
    [ObservableProperty]
    //[property: TypeConverter(typeof(UserToStringConverter))]
    private UserViewModel? _currentUser;

    ///// <summary>
    /////  Property, which will provide the list of tasks to be displayed in the MainView.
    ///// </summary>
    [ObservableProperty]
    private ObservableCollection<TaskViewModel>? _tasks;

    [ObservableProperty]
    private ObservableCollection<ProjectViewModel>? _projects;

    [ObservableProperty]
    private ObservableCollection<CategoryViewModel> _categories;

    /// <summary>
    ///  Property, which will reflect the currently selected task in the MainView. This is a 2-way binding property.
    /// </summary>
    [ObservableProperty]
    private TaskViewModel? _selectedTask;

    partial void OnSelectedTaskChanged(TaskViewModel? oldValue, TaskViewModel? newValue)
    {
        Debug.Print($"Selected Task changed from {oldValue} to {newValue}");
    }
}
