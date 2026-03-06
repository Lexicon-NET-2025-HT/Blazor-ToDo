using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ToDo.Client.State;

namespace ToDo.Client;

internal class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        builder.Services.AddSingleton<ToDoState>();

        await builder.Build().RunAsync();
    }
}
