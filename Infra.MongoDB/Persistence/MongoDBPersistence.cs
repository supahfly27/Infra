using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.MongoDB.Persistence
{
    public static class MongoDBPersistence
    {
        public static void Configure()
        {
            //ProductMap.Configure();

            //BsonDefaults.GuidRepresentation = GuidRepresentation.CSharpLegacy;
            ////BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.CSharpLegacy));

            //// Conventions
            //var pack = new ConventionPack
            //    {
            //        new IgnoreExtraElementsConvention(true),
            //        new IgnoreIfDefaultConvention(true)
            //    };
            //ConventionRegistry.Register("My Solution Conventions", pack, t => true);
        }
    }
}
