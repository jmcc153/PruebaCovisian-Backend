using System.Text.Json.Serialization;

namespace PruebaCovisian.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public double Cedula { get; set; }
        public string Nombre { get; set; }
        public double Telefono1 { get; set; }
        public double Telefono2 { get; set; }
        [JsonIgnore]
        public ICollection<Alquiler> Alquileres { get; set; }
    }
}
