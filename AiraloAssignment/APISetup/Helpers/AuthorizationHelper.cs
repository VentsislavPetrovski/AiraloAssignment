using AiraloAssignment.APISetup.Controllers;
using AiraloAssignment.APISetup.DTOs.LoginDTOs;
using AiraloAssignment.DIContainer;
using System.Net;

namespace AiraloAssignment.APISetup.Helpers
{
    public class AuthorizationHelper
    {
        private static readonly AutomationSettingsModel _settings = ContainerSession.Instance.Resolve<AutomationSettingsModel>();
        private readonly GetTokenRequestDTO _tokenRequestDTO = new()
        {
            Client_id = _settings.Client_id,
            Client_secret = _settings.Client_secret,
            Grant_type = "client_credentials"
        };
        private string? _accessToken;

        private void SetDefaultToken()
        {
            var loginResponse = new GetTokenEndpoints()
                .Login(_tokenRequestDTO).Result;
            if (loginResponse.StatusCode != HttpStatusCode.OK)
                throw new InvalidOperationException("There is no access token returned!");
            _accessToken = loginResponse.Data!.Data!.Access_token!;
        }

        public string GetDefaultToken()
        {
            if (_accessToken == null)
                SetDefaultToken();
            return _accessToken!;
        }
    }
}
