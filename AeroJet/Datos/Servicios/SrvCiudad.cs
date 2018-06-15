using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;

namespace Datos.Servicios
{
    public class SrvCiudad
    {
        public List<Ciudad> getListCiudad()
        {
            List<Ciudad> objCiudad = new List<Ciudad>();
            using (var db = new AerolíneaEntities())
            {
                objCiudad = db.Ciudad.Include("Aeropuerto").ToList();
                return objCiudad;

            }


        }

        public void AddCiudad(Ciudad item)
        {
            try
            {
                using (var db = new AerolíneaEntities())
                {
                    db.Ciudad.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }

       


    }
}
