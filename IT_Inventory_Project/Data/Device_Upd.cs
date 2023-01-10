using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IT_Inventory_Project.Data
{
    public class Device_Upd
    {
        [Required]
        [JsonProperty("token")]
        public string Token { get; set; } = string.Empty;

        [JsonProperty("DevId")]
        public string DevId { get; set; }

        [Required]
        [JsonProperty("DevType")]
        public string DevType { get; set; } = string.Empty;

        [Required]
        [JsonProperty("DevTypeOther")]
        public string DevTypeOther { get; set; } = string.Empty;

        [Required]
        [JsonProperty("Make")]
        public string Make { get; set; } = string.Empty;

        [Required]
        [JsonProperty("Model")]
        public string Model { get; set; } = string.Empty;

        [Required]
        [JsonProperty("Owner")]
        public string Owner { get; set; } = string.Empty;

        [Required]
        [JsonProperty("Location")]
        public string Location { get; set; } = string.Empty;

        [Required]
        [JsonProperty("Serial")]
        public string Serial { get; set; } = string.Empty;

        [Required]
        [JsonProperty("PurchaseDate")]
        public string PurchaseDate { get; set; }

        [Required]
        [JsonProperty("WarrantyExpDate")]
        public string WarrantyExpDate { get; set; }

        [Required]
        [JsonProperty("ServiceExpDate")]
        public string ServiceExpDate { get; set; }

        [Required]
        [JsonProperty("Value")]
        public string Value { get; set; }

        [Required]
        [JsonProperty("Size")]
        public string Size { get; set; }

        [Required]
        [JsonProperty("Toner")]
        public string Toner { get; set; }

        [Required]
        [JsonProperty("MacAddress")]
        public string MacAddress { get; set; } = string.Empty;

        [Required]
        [JsonProperty("IPAddress")]
        public string IPAddress { get; set; } = string.Empty;

        [Required]
        [JsonProperty("CellNumber")]
        public string CellNumber { get; set; } = string.Empty;

        [JsonProperty("UpdDate")]
        public string UpdDate { get; set; }

        [JsonProperty("DevStatus")]
        public string DevStatus { get; set; }
    
}
}
