using AiraloAssignment.DIContainer;
using RestSharp;

namespace AiraloAssignment.APISetup.Helpers
{
    public class ClientProvider
    {
        private string? _baseUrl;
        private RestClient? _client;
        private readonly AutomationSettingsModel _settings = ContainerSession.Instance.Resolve<AutomationSettingsModel>();

        private void InitializeBaseClient()
        {
            _baseUrl = _settings.BaseUrl!;
            _client = new RestClient(_baseUrl);
        }

        public RestClient GetBaseClient()
        {
            if (_client == null)
                InitializeBaseClient();
            return _client!;
        }
    }
}
