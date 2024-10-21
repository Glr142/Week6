// See https://aka.ms/new-console-template for more information
using GProject;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddTransient<IContactDataService, WebContactDataService>();
        services.AddTransient<ContactFinder>();
    })
    .Build();

using IServiceScope scope = host.Services.CreateScope();
IServiceProvider provider = scope.ServiceProvider;

ContactFinder contactFinder = provider.GetRequiredService<ContactFinder>();
List<Person> contacts = contactFinder.GetContactsBy("Alice");
Console.WriteLine($"We have {contacts.Count} contacts meeting our search critieria");

ContactFinder cf = new(DataServiceFactory.GetDataService());
cf.GetContactsBy("Alice").ForEach(c=> Console.WriteLine($"{c.FirstName} {c.LastName}"));