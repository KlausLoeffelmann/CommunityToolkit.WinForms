using CommunityToolkit.Mvvm.ComponentModel;
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

    public Category ToCategory()
    {
        return new Category
        {
            CategoryId = CategoryId,
            Name = Name,
            Description = Description
        };
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
