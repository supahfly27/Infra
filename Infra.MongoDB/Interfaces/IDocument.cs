using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.MongoDB.Interfaces
{
    public interface IDocument
    {
        string Id { get; set; }
        DateTime CreatedAt { get; }
    }
}
