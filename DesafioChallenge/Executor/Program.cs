using Dominio.Interfaces;
using Executor;
using Infraestrutura.Services.RpaChallengeService;
using InfraEstrutura.Services.ChromeService;
using Microsoft.Extensions.DependencyInjection;
using Infraestrutura.Services.CsvService;

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IWebDriverServices,ChromeService>();
serviceCollection.AddSingleton<IRunner, Runner>();
serviceCollection.AddSingleton<IRpaChallengeService, RpaChallengeService>();
serviceCollection.AddSingleton<ICsvService, CsvService>();



serviceCollection.BuildServiceProvider()
    .GetService<IRunner>()?.Run();