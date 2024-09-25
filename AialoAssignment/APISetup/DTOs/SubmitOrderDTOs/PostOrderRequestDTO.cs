namespace AiraloAssignment.APISetup.DTOs.SubmitOrderDTOs
{
    public class PostOrderRequestDTO
    {
        public int Quantity { get; set; }
        public string? Package_id { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? Brand_settings_name { get; set; }
    }
}
