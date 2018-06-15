using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Model;

namespace Datos.Servicios
{
    public class SrvPais
    {
        public List<Pais> getListPais()
        {
            List<Pais> objPais = new List<Pais>();
            using (var db = new AerolíneaEntities())
            {
                objPais = db.Pais.Include("Ciudad").ToList();
                return objPais;

            }

            
        }

        public void AddPais(Pais item)
        {
            try
            {
                using (var db = new AerolíneaEntities())
                {
                    db.Pais.Add(item);
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
