using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;

namespace Datos.Servicios
{
    public class SrvAerolinea
    {
        public List<Aerolinea> getListAerolinea()
        {
            List<Aerolinea> objAero = new List<Aerolinea>();
            using (var db = new AerolíneaEntities())
            {
                objAero = db.Aerolinea.Include("Avion").ToList();
                return objAero;

            }


        }

        public void AddAeroline(Aerolinea item)
        {
            try
            {
                using (var db = new AerolíneaEntities())
                {
                    db.Aerolinea.Add(item);
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
