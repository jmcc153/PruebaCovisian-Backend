using System.Text.Json.Serialization;

namespace PruebaCovisian.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Boolean disponible { get; set; }
        [JsonIgnore]
        public virtual ICollection<Alquiler> Alquileres { get; set; }

    }
}
