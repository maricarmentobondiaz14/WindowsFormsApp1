using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class WsApiexamen
    {
        public WsApiexamen() {
        
        }

        public int AgregarExamen(string nombre, string descripcion) {
            using (BdiExamenEntities db = new BdiExamenEntities() ) {
                tblExamen tblExamen = new tblExamen();
                tblExamen.nombre = nombre;
                tblExamen.descripcion = descripcion;
                db.tblExamen.Add( tblExamen );
                db.SaveChanges();


            }
            return 0;
        }
        public int ActualizarExamen(int idExamen, string nombre, string descripcion) {
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                tblExamen tblExamen= db.tblExamen.Find( idExamen );
                tblExamen.nombre = nombre;
                tblExamen.descripcion= descripcion;
                
                db.Entry( tblExamen ).State=System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


            }



            return 0;
        }

        public int EliminarExamen(int idExamen)
        {
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                tblExamen tblExamen = db.tblExamen.Find(idExamen);

                db.tblExamen.Remove(tblExamen);
                db.SaveChanges();


            }



            return 0;
        }

        public tblExamen ConsultarExamen(int idExamen)
        {
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                tblExamen tblExamen = db.tblExamen.Where(d=> d.idExamen == idExamen ).First();

                var lst = tblExamen;
                db.SaveChanges();
                return lst;



            }

        }
    }
}
