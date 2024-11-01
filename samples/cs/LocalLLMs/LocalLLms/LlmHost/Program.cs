var builder = DistributedApplication.CreateBuilder(args);

var ollama = builder
    .AddOllama("ollama", port: 50000)
    .AddModel("phi3")
    .WithDefaultModel("phi3")
    .WithContainerRuntimeArgs("--gpus=all")
    //.WithOpenWebUI(
    //    configureContainer: (res) =>
    //    {
    //        res.WithContainerName("Phi3OpenApi")
    //        .WithEndpoint(
    //            "http",
    //            callback: (epParam) => epParam.Port = 50000,
    //            createIfNotExists: true);
    //    })
    .WithDataVolume();

builder.Build().Run();
