using PruebaCovisian.Models;
namespace PruebaCovisian.Repositories
{
    public class DataBaseRepository : IRepository
    {
        public AlquilerContext _context;
        public DataBaseRepository(AlquilerContext alquilerContext)
        {
            _context = alquilerContext;
        }

        public List<AlquilerClienteCarro> GetTablesInfo(DateOnly? dateStart, DateOnly? dateEnd)
        {
            var query = _context.Alquiler.AsQueryable();

            if (dateStart != null && dateEnd != null)
            {
                query = query.Where(a => a.Fecha >= dateStart && a.Fecha <= dateEnd);
            }

            var consulta = _context.Cliente.Join(query,
                cliente => cliente.Id, alquiler => alquiler.IdCliente, (cliente, alquiler) => new { cliente, alquiler })
                .Join(_context.Carro, alquiler2 => alquiler2.alquiler.IdCarro, carro => carro.Id, (alquiler2, carro) => new AlquilerClienteCarro
                {
                    Cedula = alquiler2.cliente.Cedula,
                    Nombre = alquiler2.cliente.Nombre,
                    Fecha = alquiler2.alquiler.Fecha,
                    Tiempo = alquiler2.alquiler.Dias,
                    Saldo = alquiler2.alquiler.Saldo,
                    Placa = carro.Placa,
                    Marca = carro.Marca
                }).ToList();

            return consulta;
        }
        public int GetAlquileresMensuales(AlquilerByDate data)
        {
            return _context.Alquiler.Where(a => a.Fecha.Month == data.Fecha.Month && a.Fecha.Year == data.Fecha.Year).Count();
        }
        public int GetAlquileresDiarios(AlquilerByDate data)
        {
            return _context.Alquiler.Where(a => a.Fecha.Day == data.Fecha.Day && a.Fecha.Year == data.Fecha.Year).Count();
        }
    }

    public class AlquilerClienteCarro
    {
        public double Cedula { get; set; }
        public string Nombre { get; set; }
        public DateOnly Fecha { get; set; }
        public int Tiempo { get; set; }
        public double Saldo { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
    }
    public class AlquilerByDate
    {
        public DateOnly Fecha { get; set; }
    }

    public interface IRepository
    {
        List<AlquilerClienteCarro> GetTablesInfo(DateOnly? dateStart, DateOnly? dateEnd);
        int GetAlquileresMensuales(AlquilerByDate Fecha);
        int GetAlquileresDiarios(AlquilerByDate Fecha);
    }






}
