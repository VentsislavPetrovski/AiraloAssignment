using AiraloAssignment.APISetup.DTOs.Shared;

namespace AiraloAssignment.APISetup.DTOs.GetESimsDTOs
{
    public class GetESimsResponseDTO
    {
        public List<Data>? Data { get; set; }
        public Links? Links { get; set; }
        public Meta? Meta { get; set; }
    }

    public class Data
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
        public string? Voucher_code { get; set; }
        public string? Airalo_code { get; set; }
        public string? Apn_type { get; set; }
        public string? Apn_value { get; set; }
        public bool? Is_roaming { get; set; }
        public string? Confirmation_code { get; set; }
        public string? Order { get; set; }
        public string? Brand_settings_name { get; set; }
        public Simable? Simable { get; set; }
    }

    public class Links
    {
        public string? First { get; set; }
        public string? Last { get; set; }
        public string? Prev { get; set; }
        public string? Next { get; set; }
    }

    public class Sharing
    {
        public string? Link { get; set; }
        public string? AccessCode { get; set; }
    }

    public class Simable
    {
        public int? Id { get; set; }
        public string? Created_at { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? Package_id { get; set; }
        public int Quantity { get; set; }
        public string? Package { get; set; }
        public string? Esim_type { get; set; }
        public string? Validity { get; set; }
        public string? Price { get; set; }
        public string? Data { get; set; }
        public string? Currency { get; set; }
        public string? Manual_installation { get; set; }
        public string? Qrcode_installation { get; set; }
        public InstallationGuides? Installation_guides { get; set; }
        public Status? Status { get; set; }
        public User? User { get; set; }
        public Sharing? Sharing { get; set; }
    }

    public class Status
    {
        public string? Name { get; set; }
        public string? Slug { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string? Created_at { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Address { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Postal_code { get; set; }
        public string? Country_id { get; set; }
        public string? Company { get; set; }
    }
}
