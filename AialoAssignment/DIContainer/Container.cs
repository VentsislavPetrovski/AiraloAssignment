using AiraloAssignment.APISetup.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace AiraloAssignment.DIContainer
{
    public static class Container
    {
        public static IServiceProvider Register()
        {
            var collection = new ServiceCollection();
            collection.AddSingleton<ClientProvider>();
            collection.AddSingleton(AutomationSettings.GetAutomationSettings());
            collection.AddSingleton<AuthorizationHelper>();

            return collection.BuildServiceProvider();
        }
    }
}
