﻿using DAL.Interfaces;
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

        public Empleado Get(int id)
        {
            Empleado empleado = null;
            using (unidad = new UnidadDeTrabajo<Empleado>(new QUIZContext()))
            {
                empleado = unidad.genericDAL.Get(id);

            }
            return empleado;
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
            try
            {
                using (unidad = new UnidadDeTrabajo<Empleado>(new QUIZContext()))
                {
                    unidad.genericDAL.Update(entity);
                }
                return true;
            }catch (Exception)
            {
                return false;
            }

        }

        Empleado IDALGenerico<Empleado>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }

}
