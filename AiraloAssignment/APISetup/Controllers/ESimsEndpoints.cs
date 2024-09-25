using AiraloAssignment.APISetup.DTOs.GetESimsDTOs;
using AiraloAssignment.APISetup.Helpers;
using AiraloAssignment.DIContainer;
using RestSharp;

namespace AiraloAssignment.APISetup.Controllers
{
    public class ESimsEndpoints
    {
        private readonly RestClient _client = ContainerSession.Instance.Resolve<ClientProvider>().GetBaseClient();
        private readonly AuthorizationHelper _authorizationHelper = ContainerSession.Instance.Resolve<AuthorizationHelper>();

        public async Task<RestResponse<GetESimsResponseDTO>> GetESims(GetESimsRequestDTO? requestDTO = null)
        {
            var request = new RestRequest("/sims", Method.Get);
            request.AddHeader("Authorization", $"Bearer {_authorizationHelper.GetDefaultToken()}");

            if (requestDTO != null)
            {
                request.AddQueryParameter("include", string.Join(',', requestDTO.Include!));
                request.AddQueryParameter("created_at", requestDTO.Created_at);
                request.AddQueryParameter("iccid", requestDTO.Iccid);
                request.AddQueryParameter("limit", requestDTO.Limit);
                request.AddQueryParameter("page", requestDTO.Page);
            }

            var response = await _client.ExecuteAsync<GetESimsResponseDTO>(request);
            return response;
        }
    }
}
