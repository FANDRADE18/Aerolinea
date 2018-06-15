using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;

namespace Datos.Servicios
{
    public class SrvAeropuerto
    {
        public List<Aeropuerto> getListAeropuerto()
        {
            List<Aeropuerto> objAeropuerto = new List<Aeropuerto>();
            using (var db = new AerolíneaEntities())
            {
                objAeropuerto = db.Aeropuerto.Include("Ruta").Include("Ruta1").ToList();
                return objAeropuerto;

            }


        }

        public void AddAeropuerto(Aeropuerto item)
        {
            try
            {
                using (var db = new AerolíneaEntities())
                {
                    db.Aeropuerto.Add(item);
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
