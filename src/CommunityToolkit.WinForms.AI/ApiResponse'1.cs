namespace CommunityToolkit.WinForms.AI;

public class ApiResponse<T>
{
    public ReturnStatus ReturnStatus { get; set; }

    public string? ErrorMessage { get; set; }

    public List<T?>? Data { get; set; }
}

public enum ReturnStatus
{
    Undefined,
    Success,
    Warning,
    Error
}
