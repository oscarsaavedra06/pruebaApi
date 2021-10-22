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
        public async Task<bool> DeleteSolicitudIngreso(int id)
        {
            var item = applicationContext.solicitudIngresos.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                applicationContext.Remove(item);
                var result= await applicationContext.SaveChangesAsync();
                return result > 0;
            }

            return await Task.Run(() => false);
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

        public async Task<bool> UpdateSolicitudIngreso(int id, SolicitudIngreso entidad)
        {
            var item = applicationContext.solicitudIngresos.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return await Task.Run(() => false);
            }

            item.Nombre = entidad.Nombre;
            item.Apellido = entidad.Apellido;
            item.Identificacion = entidad.Identificacion;
            item.IdCasa = entidad.IdCasa;
            item.Edad = entidad.Edad;
            var result = await applicationContext.SaveChangesAsync();

            return result > 0;

        }


    }
}
