using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using TaskTamer.DataLayer.Models;

namespace TaskTamer.ViewModels;

public partial class CategoryViewModel : ObservableObject
{
    [ObservableProperty]
    private Guid _categoryId;

    [ObservableProperty]
    private string _name = default!;

    [ObservableProperty]
    private string? _description = default!;

    public override string ToString() => $"{Name}";

    // We need this for the ComboBox-Binding to work.
    public override bool Equals(object? obj)
        => obj is CategoryViewModel other && CategoryId == other.CategoryId;

    public Category ToCategory()
    {
        return new Category
        {
            CategoryId = CategoryId,
            Name = Name,
            Description = Description
        };
    }

    public static ObservableCollection<CategoryViewModel> GetCategories()
    {
        using TaskTamerContext context = new();
        return [.. context.Categories.Select(c => FromCategory(c)!)];
    }

    public static CategoryViewModel? FromCategory(Category? category)
    {
        if (category == null)
        {
            return null;
        }

        return new CategoryViewModel
        {
            CategoryId = category.CategoryId,
            Name = category.Name,
            Description = category.Description
        };
    }
}
