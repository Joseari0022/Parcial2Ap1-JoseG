﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Linq.Expressions;

namespace BLL
{
    public class RetencionesBll
    {
        public static bool Guardar(Retenciones rete)
        {
            using (var conexion = new Repository<Retenciones>())
            {
                try
                {
                    return conexion.Guardar(rete);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Eliminar(Entidades.Retenciones rete)
        {
            using (var conexion = new Repository<Retenciones>())
            {
                try
                {
                    return conexion.Eliminar(rete);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Modificar(Entidades.Retenciones rete)
        {
            using (var conexion = new Repository<Retenciones>())
            {
                try
                {
                    return conexion.Modificar(rete);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static Entidades.Retenciones Buscar(Expression<Func<Retenciones, bool>> Busqueda)
        {
            using (var conexion = new Repository<Retenciones>())
            {
                try
                {
                    return conexion.Buscar(Busqueda);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Entidades.Retenciones> GetList(Expression<Func<Entidades.Retenciones, bool>> Busqueda)
        {
            using (var conexion = new Repository<Retenciones>())
            {
                try
                {
                    return conexion.GetList(Busqueda);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Entidades.Retenciones> GetListTD()
        {
            using (var conexion = new Repository<Retenciones>())
            {
                try
                {
                    return conexion.GetListTD();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
