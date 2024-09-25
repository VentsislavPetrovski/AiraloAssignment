using AiraloAssignment.APISetup.DTOs.LoginDTOs;
using AiraloAssignment.APISetup.Helpers;
using AiraloAssignment.DIContainer;
using RestSharp;

namespace AiraloAssignment.APISetup.Controllers
{
    public class GetTokenEndpoints
    {
        private readonly RestClient _client = ContainerSession.Instance.Resolve<ClientProvider>().GetBaseClient();

        public async Task<RestResponse<GetTokenResponseDTO>> Login(GetTokenRequestDTO requestBody)
        {
            var request = new RestRequest("/token", Method.Post);

            request.AddParameter("client_id", requestBody.Client_id);
            request.AddParameter("client_secret", requestBody.Client_secret);
            request.AddParameter("grant_type", requestBody.Grant_type);

            var response = await _client.ExecuteAsync<GetTokenResponseDTO>(request);
            return response;
        }
    }
}
