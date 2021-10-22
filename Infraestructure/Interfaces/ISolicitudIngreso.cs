using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestructure.Interfaces
{
    public interface ISolicitudIngreso
    {
        List<SolicitudIngreso> Get();
        Task<SolicitudIngreso> GetById(int id);
        Task<bool> InsertSolicitudIngreso(SolicitudIngreso entidad);
        Task<bool> UpdateSolicitudIngreso(int id,SolicitudIngreso entidad);
        Task<bool> DeleteSolicitudIngreso(int id);
    }
}
