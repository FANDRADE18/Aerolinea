using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;

namespace Datos.Servicios
{
   public class SrvRuta
    {
        public List<Ruta> getListRuta()
        {
            List<Ruta> objRuta = new List<Ruta>();
            using (var db = new AerolíneaEntities())
            {
                objRuta = db.Ruta.Include("Vuelo").ToList();
                return objRuta;

            }


        }

        public void AddRuta(Ruta item)
        {
            try
            {
                using (var db = new AerolíneaEntities())
                {
                    db.Ruta.Add(item);
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
