using Dominio.Interfaces;
using Executor;
using Infraestrutura.Services.RpaChallengeService;
using InfraEstrutura.Services.ChromeService;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IWebDriverServices,ChromeService>();
serviceCollection.AddSingleton<IRunner, Runner>();
serviceCollection.AddSingleton<IRpaChallengeService, RpaChallengeService>();



serviceCollection.BuildServiceProvider()
    .GetService<IRunner>()?.Run();