using AiraloAssignment.APISetup.DTOs.Shared;

namespace AiraloAssignment.APISetup.DTOs.LoginDTOs
{
    public class GetTokenResponseDTO
    {
        public Data? Data { get; set; }
        public Meta? Meta { get; set; }
    }

    public class Data
    {
        public string? Token_type { get; set; }
        public long Expires_in { get; set; }
        public string? Access_token { get; set; }
    }
}
