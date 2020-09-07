using Newtonsoft.Json;
using System;

namespace WindowsFormsApp1.Models
{
    public class OrderItem
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "order")]
        public Order Order { get; set; }
        [JsonProperty(PropertyName = "product")]
        public Product Product { get; set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created_At { get; set; }
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? Updated_At { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
