using System.Collections.Generic;

namespace PetOwner.Infrastructure.Services.Models
{
    class Owner
    {
        //[JsonProperty("name")]
        public string Name { get; set; }

        //[JsonProperty("gender")]
        public string Gender { get; set; }

       // [JsonProperty("age")]
        public long Age { get; set; }

        //[JsonProperty("pets")]
        public IEnumerable<Pet> Pets { get; set; }
    }
}
