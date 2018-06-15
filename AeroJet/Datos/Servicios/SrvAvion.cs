using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;

namespace Datos.Servicios
{
   public class SrvAvion
    {
        public List<Avion> getListAvion()
        {
            List<Avion> objAvion = new List<Avion>();
            using (var db = new AerolíneaEntities())
            {
                objAvion = db.Avion.Include("Secciones").Include("Vuelo").ToList();
                return objAvion;

            }


        }

        public void AddAvion(Avion item)
        {
            try
            {
                using (var db = new AerolíneaEntities())
                {
                    db.Avion.Add(item);
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
