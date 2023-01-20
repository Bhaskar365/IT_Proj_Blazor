using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IT_Inventory_Project.Data
{
    public class Device_Upd
    {
        [JsonProperty("token")]
        [Required]
        public string Token { get; set; } = string.Empty;

        [JsonProperty("DevId")]
        public string DevId { get; set; }

        [JsonProperty("DevType")]
        [Required]
        public string DevType { get; set; } = string.Empty;

        [JsonProperty("DevTypeOther")]
        [Required]
        public string DevTypeOther { get; set; } = string.Empty;

        [JsonProperty("Make")]
        [Required]
        public string Make { get; set; } = string.Empty;
        
        [JsonProperty("Model")]
        [Required]
        public string Model { get; set; } = string.Empty;

        [JsonProperty("Owner")]
        [Required]
        public string Owner { get; set; } = string.Empty;

        [JsonProperty("Location")]
        [Required]
        public string Location { get; set; } = string.Empty;

        [JsonProperty("Serial")]
        [Required]
        public string Serial { get; set; } = string.Empty;

        [JsonProperty("PurchaseDate")]
        [Required]
        public string PurchaseDate { get; set; }

        [JsonProperty("WarrantyExpDate")]
        [Required]
        public string WarrantyExpDate { get; set; }

        [JsonProperty("ServiceExpDate")]
        [Required]
        public string ServiceExpDate { get; set; }

        [JsonProperty("Value")]
        [Required]
        public string Value { get; set; }

        [JsonProperty("Size")]
        [Required]
        public string Size { get; set; }

        [JsonProperty("Toner")]
        [Required]
        public string Toner { get; set; }
        
        [JsonProperty("MacAddress")]
        [Required]
        public string MacAddress { get; set; } = string.Empty;
        
        [JsonProperty("IPAddress")]
        [Required]
        public string IPAddress { get; set; } = string.Empty;
        
        [JsonProperty("CellNumber")]
        [Required]
        public string CellNumber { get; set; } = string.Empty;

        [JsonProperty("UpdDate")]
        public string UpdDate { get; set; }

        [JsonProperty("DevStatus")]
        public string DevStatus { get; set; }
    
}
}
