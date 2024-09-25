namespace AiraloAssignment.APISetup.DTOs.GetESimsDTOs
{
    public class GetESimsRequestDTO
    {
        public List<string>? Include { get; set; }
        public string? Created_at { get; set; }
        public string? Iccid { get; set; }
        public int Limit { get; set; }
        public int Page { get; set; }
    }
}
