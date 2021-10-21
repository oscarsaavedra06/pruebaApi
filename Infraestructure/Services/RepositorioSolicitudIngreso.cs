using Core.Models;
using Infraestructure.Data;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Services
{
    public class RepositorioSolicitudIngreso : ISolicitudIngreso
    {
        private readonly ApplicationContext applicationContext;

        public RepositorioSolicitudIngreso(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        public Task<bool> DeleteSolicitudIngreso(SolicitudIngreso entidad)
        {
            throw new NotImplementedException();
        }

        public List<SolicitudIngreso> Get()
        {
            return applicationContext.solicitudIngresos.ToList();
        }

        public Task<SolicitudIngreso> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertSolicitudIngreso(SolicitudIngreso entidad)
        {
            await applicationContext.AddAsync(entidad);
            var result = await applicationContext.SaveChangesAsync();
            return result > 0;
        }

        public Task<bool> UpdateSolicitudIngreso(int id, SolicitudIngreso entidad)
        {
            var item = applicationContext.solicitudIngresos.FirstOrDefault(x => x.Id == id);
            if (item == null) {
                return Task.Run(()=> false);
            }


            return Task.Run(() => false);

        }
    }
}
