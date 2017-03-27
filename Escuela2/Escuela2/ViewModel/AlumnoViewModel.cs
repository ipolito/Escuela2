using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using Escuela2.Models;

namespace Escuela2.ViewModel
{
    public class AlumnoViewModel
    {
        public static List<Alumno> ListarContenido()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Alumnos.Where(r => r.bStatus == true).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Alumno DetalleAlumno(int id)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Alumnos.Where(r => r.bStatus == true && r.pkAlumno == id).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
