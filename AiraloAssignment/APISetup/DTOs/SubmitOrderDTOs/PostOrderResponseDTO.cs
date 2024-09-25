using AiraloAssignment.APISetup.DTOs.Shared;

namespace AiraloAssignment.APISetup.DTOs.SubmitOrderDTOs
{
    public class PostOrderResponseDTO
    {
        public Datum? Data { get; set; }
        public Meta? Meta { get; set; }
    }

    public class Datum
    {
        public string? Package_id { get; set; }
        public int Quantity { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? Esim_type { get; set; }
        public int Validity { get; set; }
        public string? Package { get; set; }
        public string? Data { get; set; }
        public double? Price { get; set; }
        public string? Created_at { get; set; }
        public int? Id { get; set; }
        public string? Code { get; set; }
        public string? Currency { get; set; }
        public string? Manual_installation { get; set; }
        public string? Qrcode_installation { get; set; }
        public InstallationGuides? Installation_guides { get; set; }
        public string? Brand_settings_name { get; set; }
        public List<Sim>? Sims { get; set; }
    }

    public class Sim
    {
        public int Id { get; set; }
        public string? Created_at { get; set; }
        public string? Iccid { get; set; }
        public string? Lpa { get; set; }
        public string? Imsis { get; set; }
        public string? Matching_id { get; set; }
        public string? Qrcode { get; set; }
        public string? Qrcode_url { get; set; }
        public string? Direct_apple_installation_url { get; set; }
        public string? Airalo_code { get; set; }
        public string? Apn_type { get; set; }
        public string? Apn_value { get; set; }
        public bool? Is_roaming { get; set; }
        public string? Confirmation_code { get; set; }
    }
}
