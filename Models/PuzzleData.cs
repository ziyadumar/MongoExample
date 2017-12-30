using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Bubbles.Models
{
    [BsonIgnoreExtraElements]
    public class PuzzleData
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public string Id { get; set; }
        public List<PuzzleImage> Images { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }
    }

    public class PuzzleImage
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string Url { get; set; }
    }
}