namespace CommunityToolkit.DesktopGeneric.Mvvm.Services;

internal static class ServiceProviderExtension
{
    public static T GetRequiredService<T>(this IServiceProvider serviceProvider)
        where T : class
    {
        return serviceProvider.GetService(typeof(T)) as T 
            ?? throw new InvalidOperationException($"Service of type {typeof(T)} not found.");
    }
}
