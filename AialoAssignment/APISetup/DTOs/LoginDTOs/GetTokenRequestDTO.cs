namespace AiraloAssignment.APISetup.DTOs.LoginDTOs
{
    public class GetTokenRequestDTO
    {
        public string? Client_id { get; set; }
        public string? Client_secret { get; set; }
        public string? Grant_type { get; set; }
    }
}
