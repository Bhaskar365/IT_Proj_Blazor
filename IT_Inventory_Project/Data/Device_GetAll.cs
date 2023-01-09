using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace IT_Inventory_Project.Data
{
    public class Device_GetAll{ 

        [JsonProperty("token")]
        public string Token { get; set; } = string.Empty;

        [JsonProperty("DevId")]
        public int DevId { get; set; }

        [JsonProperty("DevType")]
        public string DevType { get; set; } = string.Empty;

        [JsonProperty("DevTypeOther")]
        public string DevTypeOther { get; set; } = string.Empty;

        [JsonProperty("Make")]
        public string Make { get; set; } = string.Empty;

        [JsonProperty("Model")]
        public string Model { get; set; } = string.Empty;

        [JsonProperty("Owner")]
        public string Owner { get; set; } = string.Empty;

        [JsonProperty("Location")]
        public string Location { get; set; } = string.Empty;

        [JsonProperty("Serial")]
        public string Serial { get; set; } = string.Empty;

        [JsonProperty("PurchaseDate")]
        public DateTime PurchaseDate { get; set; }

        [JsonProperty("WarrantyExpDate")]
        public DateTime WarrantyExpDate { get; set; }

        [JsonProperty("ServiceExpDate")]
        public DateTime ServiceExpDate { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }

        [JsonProperty("Size")]
        public string Size { get; set; }

        [JsonProperty("Toner")]
        public string Toner { get; set; }

        [JsonProperty("MacAddress")]
        public string MacAddress { get; set; } = string.Empty;

        [JsonProperty("IPAddress")]
        public string IPAddress { get; set; } = string.Empty;

        [JsonProperty("CellNumber")]
        public string CellNumber { get; set; } = string.Empty;

        [JsonProperty("UpdDate")]
        public DateTime UpdDate { get; set; }

        [JsonProperty("DevStatus")]
        public int DevStatus { get; set; }
    }
 }
