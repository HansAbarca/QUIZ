using DAL.Interfaces;
using Entities.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class EmpleadoDALImpl : IEmpleadoDAL
    {
        private QUIZContext QUIZContext;
        private UnidadDeTrabajo<Empleado> unidad;
        public bool Add(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleado> Find(Expression<Func<Empleado, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleado> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleado> GetAll()
        {
            IEnumerable<Empleado> empleados = null;
            using (unidad = new UnidadDeTrabajo<Empleado>(new QUIZContext()))
            {
                empleados = unidad.genericDAL.GetAll();

            }
            return empleados;
        }

        public bool Remove(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }

        public Empleado SingleOrDefault(Expression<Func<Empleado, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Empleado entity)
        {
            throw new NotImplementedException();
        }
    }

}
