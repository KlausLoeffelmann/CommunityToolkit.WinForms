using TaskTamer.DTOs;

namespace TaskTamer.DataLayer.Models;

public partial class TaskItem
{
    public static void EnsureSampleTasksData(TaskTamerContext context, User user)
    {
        var sampleTasks = GenerateTasks();

        var projects = context.Projects.ToArray();
        var categories = context.Categories.ToArray();

        var random = new Random();

        foreach (var taskText in sampleTasks)
        {
            // Check if sample tasks have been created
            if (context.TaskItems.FirstOrDefault(
                task => task.Explanation == taskText.Name) is TaskItem task)
            {
                // Implement the logic to update the due dates of the tasks in the database
                task.DueDate = CalculateNewDueDate(task.DueDate ?? DateTimeOffset.Now);
            }
            else
            {
                var now = DateTimeOffset.Now;
                var dueDate = now.AddDays(random.Next(15, 30)).AddHours(random.Next(24));
                var created = now.AddDays(-random.Next(30, 90)).AddHours(random.Next(24));
                var modified = created.AddDays(random.Next(5, 25)).AddHours(random.Next(24));

                // Create new sample tasks
                task = new()
                {
                    Explanation = taskText.Name,
                    DueDate  = dueDate,
                    DateCreated = created,
                    DateLastModified = modified,
                    Status= (TaskItemStatus) random.Next(1, 6),
                    Notes = taskText.Description,
                    Owner = user,
                    Category = categories[random.Next(categories.Length)],
                    Project = projects[random.Next(projects.Length)]
                };

                context.TaskItems.Add(task);
            }
        }

        context.SaveChanges();
    }

    private static (string Name, string Description, int categoryIndex, int projectIndex)[] GenerateTasks()
    {
        (string Name, string Description, int categoryIndex, int projectIndex)[] tasks =
        [
            // C# Development and WinForms Designer
            ("Implement new property grid", "Design and implement an advanced property grid for the WinForms Designer.", 1, 0),
            ("Optimize rendering performance", "Improve the rendering performance of the designer to handle complex forms.", 1, 0),
            ("Fix layout issues in designer", "Resolve layout problems when controls are nested deeply.", 1, 0),
            ("Add support for new control types", "Extend the designer to support custom and third-party controls.", 1, 0),
            ("Improve error reporting", "Enhance error messages and reporting mechanisms in the designer.", 1, 0),

            // C# Development and WinForms Community Toolkit
            ("Add MVVM support", "Implement MVVM pattern support in the toolkit.", 1, 4),
            ("Create sample applications", "Develop sample applications demonstrating toolkit features.", 1, 4),
            ("Implement new components", "Develop new UI components for the toolkit.", 1, 4),

            // Doc Writing and WinForms Community Toolkit
            ("Document MVVM pattern usage", "Write detailed documentation on how to implement MVVM with the toolkit.", 4, 4),
            ("Update API references", "Ensure all new APIs are properly documented.", 4, 4),
            ("Create tutorial for beginners", "Write a beginner-friendly tutorial on using the toolkit.", 4, 4),

            // Blog Writing and New .NET 10 APIs
            ("Write blog post on new .NET 10 features", "Highlight the key new features in .NET 10.", 5, 3),
            ("Interview developers about .NET 10", "Interview core team developers about the upcoming changes.", 5, 3),
            ("Create performance comparison charts", "Generate charts comparing .NET 9 and .NET 10 performance.", 5, 3),

            // Rust Development and Security Analyzers
            ("Implement Rust security analyzer", "Develop a security analyzer for Rust code.", 3, 5),
            ("Integrate with Cargo", "Ensure the analyzer works seamlessly with the Rust build tool Cargo.", 3, 5),
            ("Write test cases for Rust analyzer", "Create comprehensive test cases to validate the analyzer.", 3, 5),

            // Book Writing and Writing ADHD Book
            ("Outline chapter on time management", "Draft the outline for the time management chapter.", 6, 1),
            ("Research latest ADHD studies", "Gather recent studies to include in the book.", 6, 1),
            ("Write introduction", "Compose the introduction chapter.", 6, 1),
            ("Edit chapter on medication", "Revise and edit the medication chapter for clarity.", 6, 1),
            ("Design cover art", "Create or commission cover art for the book.", 6, 1),

            // Visual Basic Development and Servicing .NET 9
            ("Fix bug in VB compiler", "Address the reported bug in the Visual Basic compiler for .NET 9.", 2, 2),
            ("Update VB templates", "Update Visual Basic project templates for .NET 9.", 2, 2),
            ("Optimize VB runtime", "Improve the performance of the Visual Basic runtime.", 2, 2),

            // C# Development and New .NET 10 APIs
            ("Implement new LINQ extensions", "Develop and integrate new LINQ extension methods.", 1, 3),
            ("Add Span<T> enhancements", "Optimize Span<T> for better performance.", 1, 3),
            ("Refactor async streams", "Improve async streams for better usability.", 1, 3),
            ("Implement source generators", "Create new source generators for code optimization.", 1, 3),
            ("Update Roslyn analyzers", "Enhance Roslyn analyzers to support new language features.", 1, 3),

            // Doc Writing and New .NET 10 APIs
            ("Update .NET 10 API documentation", "Document all the new APIs introduced in .NET 10.", 4, 3),
            ("Create migration guides", "Write guides to help developers migrate from .NET 9 to .NET 10.", 4, 3),
            ("Write samples for new features", "Develop code samples illustrating new .NET 10 features.", 4, 3),

            // Blog Writing and WinForms Designer
            ("Announce new designer features", "Write a blog post announcing the new features in the WinForms Designer.", 5, 0),
            ("Tutorial on new data binding", "Create a tutorial on how to use the new data binding features.", 5, 0),
            ("Interview with the design team", "Interview the team behind the WinForms Designer.", 5, 0),

            // Doc Writing and WinForms Designer
            ("Update designer documentation", "Revise the documentation to reflect changes in the new designer.", 4, 0),
            ("Create FAQ", "Compile a list of frequently asked questions about the new designer.", 4, 0),
            ("Write troubleshooting guide", "Develop a guide to help users troubleshoot common issues.", 4, 0),

            // Rust Development and New .NET 10 APIs
            ("Implement Rust interop with .NET 10", "Develop interoperability between Rust and .NET 10.", 3, 3),
            ("Create Rust bindings for new APIs", "Generate Rust bindings for the new .NET 10 APIs.", 3, 3),
            ("Benchmark Rust vs. .NET performance", "Compare performance between Rust and .NET 10.", 3, 3),

            // Doc Writing and Writing ADHD Book
            ("Edit drafts for clarity", "Review and edit book drafts for clarity and flow.", 4, 1),
            ("Format references", "Ensure all references are properly formatted.", 4, 1),
            ("Create index and glossary", "Compile an index and glossary for the book.", 4, 1),

            // Blog Writing and Security Analyzers
            ("Write about latest security threats", "Blog about the latest security threats and how the analyzers can help.", 5, 5),
            ("Guide on using security analyzers", "Create a step-by-step guide on using the security analyzers.", 5, 5),
            ("Interview security experts", "Interview experts about the importance of code security.", 5, 5),

            // Doc Writing and Security Analyzers
            ("Update analyzer documentation", "Revise and expand the documentation for security analyzers.", 4, 5),
            ("Create rule descriptions", "Write detailed descriptions for each security rule.", 4, 5),
            ("Develop user manuals", "Produce comprehensive user manuals for the analyzers.", 4, 5),

            // Visual Basic Development and WinForms Community Toolkit
            ("Port toolkit to VB", "Adapt the WinForms Community Toolkit to Visual Basic.", 2, 4),
            ("Fix VB compatibility issues", "Resolve any compatibility issues between VB and the toolkit.", 2, 4),
            ("Write VB examples", "Provide Visual Basic code examples for the toolkit.", 2, 4),

            // Book Writing and WinForms Community Toolkit
            ("Write a guidebook on toolkit", "Author a book on how to use the WinForms Community Toolkit effectively.", 6, 4),
            ("Create sample projects for book", "Develop sample projects to include in the book.", 6, 4),
            ("Edit chapters on advanced usage", "Edit the chapters covering advanced toolkit features.", 6, 4),

            // Blog Writing and Writing ADHD Book
            ("Blog about writing process", "Share insights about the process of writing the ADHD book.", 5, 1),
            ("Promote upcoming book", "Write promotional content for the upcoming book.", 5, 1),
            ("Discuss ADHD research", "Blog about recent ADHD research findings.", 5, 1),

            // Funny Tasks
            ("Develop AI that writes code", "Create an AI that can write code better than humans.", 0, 2),
            ("Build a self-debugging program", "Develop software that can debug itself autonomously.", 0, 3),
            ("Invent a programming language that programs itself", "Create a language that writes its own code.", 0, 2),
            ("Fix the flux capacitor", "The flux capacitor in the time machine is malfunctioning. It needs to be fixed to ensure smooth time travel.", 0, 0),
            ("Teach penguins to fly", "Penguins have expressed a strong desire to fly. Develop a training program to teach them how to take flight.", 0, 0),
            ("Find the lost city of Atlantis", "Embark on an underwater expedition to discover the mythical lost city of Atlantis and unravel its secrets.", 0, 0),
            ("Create a time machine", "Build a functional time machine that can transport individuals to different points in time.", 0, 0),
            ("Invent a teleportation device", "Design and construct a teleportation device that can instantly transport objects and people across vast distances.", 0, 0),
            ("Train a squirrel army", "Train a group of squirrels to become a highly skilled army capable of executing complex missions.", 0, 0),
            ("Build a robot butler", "Construct an advanced robot with the ability to perform household tasks and assist with daily activities.", 0, 0),
            ("Discover the meaning of life", "Embark on a philosophical journey to uncover the true meaning and purpose of life.", 0, 0),
            ("Become a superhero", "Develop superhuman abilities and use them to protect the innocent and fight against evil.", 0, 0),
            ("Conquer the world with rubber ducks", "Devise a plan to take over the world using an army of rubber ducks as your secret weapon.", 0, 0),
            ("Solve the mystery of the Bermuda Triangle", "Investigate the Bermuda Triangle phenomenon and solve the mystery behind the disappearances of ships and planes.", 0, 0),
            ("Create a language only you can understand", "Invent a unique language that only you can comprehend, allowing for secure communication and secret knowledge.", 0, 0),
            ("Find Bigfoot", "Embark on an expedition to locate and document the existence of the legendary creature known as Bigfoot.", 0, 0),
            ("Become a professional unicorn rider", "Train to become a skilled unicorn rider and participate in magical races and competitions.", 0, 0),
            ("Design a hat for cats", "Create fashionable and comfortable hats specifically designed for cats, taking into account their unique anatomy.", 0, 0),
            ("Create a recipe for invisible cookies", "Develop a recipe for cookies that become invisible upon consumption, adding an element of surprise to the dining experience.", 0, 0),
            ("Build a treehouse on Mars", "Construct a habitable treehouse on the surface of Mars, providing a unique living space for future explorers.", 0, 0),
            ("Write a novel using only emojis", "Challenge yourself to write an entire novel using only emojis, pushing the boundaries of communication.", 0, 0),
            ("Become a professional bubble wrap popper", "Master the art of popping bubble wrap and achieve the status of a professional bubble wrap popper.", 0, 0),
            ("Invent a self-cleaning house", "Design and build a house equipped with advanced self-cleaning mechanisms, eliminating the need for manual cleaning.", 0, 0),
            ("Create a flying car", "Engineer a revolutionary flying car that combines the convenience of road transportation with the freedom of flight.", 0, 0),
            ("Build a time-traveling toaster", "Construct a toaster that has the ability to transport toast to different points in time, ensuring perfectly timed breakfasts.", 0, 0),
            ("Train a dragon", "Tame and train a mythical dragon, forming a bond of trust and using its abilities for various purposes.", 0, 0),
            ("Discover a new planet", "Explore the depths of space and discover a previously unknown planet, expanding our knowledge of the universe.", 0, 0),
            ("Invent a device to read minds", "Create a groundbreaking device that can accurately read and interpret the thoughts and emotions of individuals.", 0, 0),
            ("Become a master of disguise", "Master the art of disguise, acquiring the skills to transform your appearance and blend seamlessly into any environment.", 0, 0),
            ("Solve a murder mystery", "Put your detective skills to the test and solve a complex murder mystery, uncovering the truth behind the crime.", 0, 0),
            ("Create a cure for the common cold", "Devise a cure for the common cold, alleviating the symptoms and providing relief to millions of people.", 0, 0),
            ("Build a floating city", "Design and construct a fully functional floating city, revolutionizing the concept of urban living.", 0, 0),
            ("Design a robot pet", "Create a lifelike robot pet that can provide companionship and emotional support, mimicking the behavior of real animals.", 0, 0)
        ];

        return tasks;
    }

    private static DateTimeOffset CalculateNewDueDate(DateTimeOffset dueDate)
    {
        // Calculate the minimum and maximum offset from the current date
        TimeSpan minOffset = TimeSpan.FromDays(1); // Minimum offset of 1 day
        TimeSpan maxOffset = TimeSpan.FromDays(7); // Maximum offset of 7 days

        // Generate a random offset within the specified range
        Random random = new();
        TimeSpan randomOffset = TimeSpan
            .FromTicks((long)random.NextDouble() * (maxOffset.Ticks - minOffset.Ticks) + minOffset.Ticks);

        // Calculate the new due date by adding the random offset to the original due date
        DateTimeOffset newDueDate = dueDate + randomOffset;

        return newDueDate;
    }

    public static void CreateNew(
        string newTaskName,
        DateTimeOffset? newTaskDueDate,
        Guid projectId,
        Guid userId)
    {
        var context = new TaskTamerContext();

        // Create new sample tasks
        TaskItem task = new()
        {
            Explanation = newTaskName,
            DueDate = newTaskDueDate,
            DateCreated = DateTimeOffset.Now,
            DateLastModified = DateTimeOffset.Now,
            Status = TaskItemStatus.NotStarted,
            Owner = context.Users.Find(userId)!,
            Project = context.Projects.Find(projectId)
        };

        context.TaskItems.Add(task);
        context.SaveChanges();
    }
}
