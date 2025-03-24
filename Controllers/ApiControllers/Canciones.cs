using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("canciones")]
public class Conexion : Controller
{
[HttpGet("mongo")]
public IActionResult CancionesdeJuniorHMongoDb()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_BD);
    var db = client.GetDatabase("Practica2_Yuliana_Danna");
    var collection = db.GetCollection<CancionesMongo>("canciones de junior h");
    var lista = collection.Find(FilterDefinition<CancionesMongo>.Empty).ToList();
    return Ok(lista);
}
}

