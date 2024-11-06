using CommunityToolkit.WinForms.AI;
using NJsonSchema;
using SampleDataNamespace;

namespace SampleDataNamespace
{
    public record DemoClass(string? Name, int Age);
}

namespace JsonSchemaGenerator
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            // We need that to use the clipboard.
            AppContext.SetSwitch("System.Threading.SetMainThreadIsSTA", true);

            Type type = typeof(ApiResponse<DemoClass>);

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine($"Welcome to the Json Schema Generator for .NET Types!");
            Console.WriteLine($"(Using NJson by Rico Suter - find it on GitHub!)");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"The JSON Schema for the type:{type} is:");

            JsonSchema schema = JsonSchema.FromType<ApiResponse<DemoClass>>();
            string schemaData = schema.ToJson();

            System.Windows.Forms.Clipboard.SetText(schemaData);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"The JSON Schema Data for the type:{type} is:");
            Console.WriteLine($"{schemaData}:");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"The schema string has been copied into the clipboard.");
        }
    }
}
