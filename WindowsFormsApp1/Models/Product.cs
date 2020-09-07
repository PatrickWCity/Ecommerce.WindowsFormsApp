using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Models
{
    public class Product
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "category")]
        public Category Category { get; set; }
        [JsonProperty(PropertyName = "supplier")]
        public Supplier Supplier { get; set; }
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created_At { get; set; }
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? Updated_At { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
