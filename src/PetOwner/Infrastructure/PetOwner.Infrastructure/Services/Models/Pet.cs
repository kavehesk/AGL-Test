using System;
using System.Text;

namespace PetOwner.Infrastructure.Services.Models
{
    class Pet
    {
        //[JsonProperty("name")]
        public string Name { get; set; }

       // [JsonProperty("type")]
        public string Type { get; set; }
    }
}
