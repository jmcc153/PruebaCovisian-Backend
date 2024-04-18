namespace PruebaCovisian.Models
{
    public class Pagos
    {
        public int Id { get; set; }
        public int IdAlquiler { get; set; }
        public DateOnly Fecha { get; set; }
        public double Valor { get; set; }
        public virtual Alquiler? Alquiler { get; set; }
    }
}
