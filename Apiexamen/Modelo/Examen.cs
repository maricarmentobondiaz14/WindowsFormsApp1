using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiexamen.Modelo
{
    public class Examen
    {
        private int identificador;
        private string nombre;
        private string descripcion;

        public Examen()
        {
        }
        public Examen(int identificador
            , string nombre
            , string descripcion
           )
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.descripcion = descripcion;


        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }


    }
}
