var builder = DistributedApplication.CreateBuilder(args);

var ollama = builder.AddContainer("ollama", "ollama/ollama", "latest")
    .WithBindMount("./ollamaconfig", "/usr/config")
    .WithVolume("ollama", "/root/.ollama")
    .WithHttpEndpoint(11434, 11434, "ollama")
    .WithEnvironment("OLLAMA_DEBUG", "1")
    .WithContainerRuntimeArgs("--gpus=all"); 

builder.Build().Run();
