using Microsoft.Extensions.Configuration;

namespace AiraloAssignment.APISetup.Helpers
{
    public class AutomationSettings
    {
        public static AutomationSettingsModel GetAutomationSettings()
        {
            var settings = new AutomationSettingsModel();
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            config.GetSection("AutomationSettings").Bind(settings);
            return settings;
        }
    }

    public record AutomationSettingsModel
    {
        public string? BaseUrl { get; set; }
        public string? Client_id { get; set; }
        public string? Client_secret { get; set; }
    }
}
