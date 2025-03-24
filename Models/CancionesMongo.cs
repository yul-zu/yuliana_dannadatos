using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class CancionesMongo
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string titulo { get; set; } = string.Empty;

    public string album { get; set; } = string.Empty;

    public int año { get; set; }

    public double duracion { get; set; }

    public string genero { get; set; } = string.Empty;

    public string colaboracion { get; set; } = string.Empty;

    public int popularidad { get; set; }

    public long views_youtube { get; set; }
}
