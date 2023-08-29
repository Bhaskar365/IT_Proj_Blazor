using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IT_Inventory_Project.Data
{
    public class Device_Add
    {
        
        [JsonProperty("token")]
        [Required]
        public string Token { get; set; } = string.Empty;

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
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        [JsonProperty("WarrantyExpDate")]
        [Required]
        public DateTime WarrantyExpDate { get; set; } = DateTime.Now;

        [JsonProperty("ServiceExpDate")]
        [Required]
        public DateTime ServiceExpDate { get; set; } = DateTime.Now;

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
