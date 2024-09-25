using AiraloAssignment.APISetup.DTOs.SubmitOrderDTOs;
using AiraloAssignment.APISetup.Helpers;
using AiraloAssignment.DIContainer;
using RestSharp;

namespace AiraloAssignment.APISetup.Controllers
{
    public class OrderEndpoints
    {
        private readonly RestClient _restClient = ContainerSession.Instance.Resolve<ClientProvider>().GetBaseClient();
        private readonly AuthorizationHelper _authorizationHelper = ContainerSession.Instance.Resolve<AuthorizationHelper>();

        public async Task<RestResponse<PostOrderResponseDTO>> PostOrder(PostOrderRequestDTO requestDTO)
        {
            var request = new RestRequest("/orders", Method.Post);

            request.AddHeader("Authorization", $"Bearer {_authorizationHelper.GetDefaultToken()}");
            request.AddParameter("quantity", requestDTO.Quantity);
            request.AddParameter("package_id", requestDTO.Package_id);
            request.AddParameter("type", requestDTO.Type);
            request.AddParameter("description", requestDTO.Description);
            request.AddParameter("brand_settings_name", requestDTO.Brand_settings_name);

            var response = await _restClient.ExecuteAsync<PostOrderResponseDTO>(request);
            return response;
        }
    }
}
