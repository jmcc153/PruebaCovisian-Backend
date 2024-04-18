using PruebaCovisian.Repositories;

namespace PruebaCovisian.Services
{
    public class AlquilerService: IAlquilerService
    {
        public readonly IRepository _alquilerService;
        public AlquilerService(IRepository dataBaseService)
        {
            _alquilerService = dataBaseService;
        }

        public List<AlquilerClienteCarro> GetTablesInfo(DateOnly? dateStart, DateOnly? dateEnd)
        {
            return _alquilerService.GetTablesInfo(dateStart, dateEnd);
        }
        public int GetAlquileresMensuales(AlquilerByDate Fecha)
        {
            return _alquilerService.GetAlquileresMensuales(Fecha);
        }
        public int GetAlquileresDiarios(AlquilerByDate Fecha)
        {
            return _alquilerService.GetAlquileresDiarios(Fecha);
        }

    }
    public interface IAlquilerService
    {
        List<AlquilerClienteCarro> GetTablesInfo(DateOnly? dateStart, DateOnly? dateEnd);
        int GetAlquileresMensuales(AlquilerByDate Fecha);
        int GetAlquileresDiarios(AlquilerByDate Fecha);
    }

}
