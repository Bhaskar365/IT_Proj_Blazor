using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace IT_Inventory_Project.Data
{
    public class Device_GetAll
    {
        [Required]
        [JsonProperty("token")]
        public string Token { get; set; } = string.Empty;

        [Required]
        [JsonProperty("DevId")]
        public string DevId { get; set; } = string.Empty;

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
        public DateTime? PurchaseDate { get; set; }

        [Required]
        [JsonProperty("WarrantyExpDate")]
        public DateTime? WarrantyExpDate { get; set; }


        [Required]
        [JsonProperty("ServiceExpDate")]
        public DateTime? ServiceExpDate { get; set; }


        [Required]
        [JsonProperty("Value")]
        public string Value { get; set; } = string.Empty;

        [Required]
        [JsonProperty("Size")]
        public string Size { get; set; } = string.Empty;

        [Required]
        [JsonProperty("Toner")]
        public string Toner { get; set; } = string.Empty;

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
