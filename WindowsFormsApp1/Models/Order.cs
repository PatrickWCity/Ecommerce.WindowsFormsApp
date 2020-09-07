using Newtonsoft.Json;
using System;

namespace WindowsFormsApp1.Models
{
    public class Order
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "employee")]
        public Employee Employee { get; set; }
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
