using System.Text.Json.Serialization;

namespace PruebaCovisian.Models
{
    public class Alquiler
    {
        public int Id { get; set; }
        public int IdCarro { get; set; }
        public int IdCliente { get; set; }
        public DateOnly Fecha { get; set; }
        public int Dias { get; set; }
        public double ValorTotal { get; set; }
        public double Saldo { get; set; }
        public double AbonoInicial { get; set; }
        public Boolean Devuelto { get; set; }
        public virtual Carro Carro { get; set; }
        public virtual Cliente Cliente { get; set; }
        [JsonIgnore]
        public virtual ICollection<Pagos> Pagos { get; set; }
    }
}
