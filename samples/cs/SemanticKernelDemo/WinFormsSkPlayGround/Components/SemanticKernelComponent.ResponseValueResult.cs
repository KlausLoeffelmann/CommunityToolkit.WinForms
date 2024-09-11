namespace SemanticKernelDemo.SemanticKernel;

#pragma warning disable SKEXP0010
public partial class SemanticKernelComponent
{
    /// <summary>
    ///  Provides the typed value response result along with a potential status message.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public record class ResponseValueResult<T>
    {
        public ResponseValueResult(string response, T? value)
        {
            Response = response;
            Value = value;
        }

        public string Response { get; } = string.Empty;

        public T? Value { get; } = default;
    }
}
#pragma warning restore SKEXP0010
