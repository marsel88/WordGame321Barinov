using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WordGame321Barinov
{
     class Words
    {
        [BsonId]
        public ObjectId QuestionId { get; set; }
        [BsonElement("question")]
        public string Question { get; set; }
        [BsonElement("answer")]
        public string Answer { get; set; }
    }
}
