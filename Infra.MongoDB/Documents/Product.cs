using Infra.MongoDB.Models;

namespace Infra.MongoDB.Documents
{
    [BsonCollection("product")]
    public class Product : Document
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
