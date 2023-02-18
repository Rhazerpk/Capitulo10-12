using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10_12
{
    class Inventario
    {
        private string referencia;
        private int cantidad;
        public void setReferencia(string a) { referencia = a; }
        public void setCantidad(int e) { cantidad = e; }
        public string getReferencia() { return referencia; }
        public int getCantidad() { return cantidad; }
        public void visualizar()
        {
            string referencia;
            int cantidad;
            Inventario a1 = new Inventario();
            Console.WriteLine("Ingrese una refencia de productos: ");
            referencia = Console.ReadLine();
            a1.setReferencia(referencia);
            Console.WriteLine("Ingrese cantidad: ");
            cantidad = Int32.Parse(Console.ReadLine());
            a1.setCantidad(cantidad);

            Console.WriteLine(getReferencia() + getCantidad());

            Estudiantes s = new Estudiantes();
            s.Mostrar();
        }
    }

    class Estudiantes
    {
        private string nombre = "Cristiano";
        private string apellido = "Ronaldo";
        private int edad = 38;
        private string estadocivil = "Casado";
        private string Tiposangre = "O+";
        private string direccion = "Calle lisboa Perla, Lisboa, Portugal";

        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getnombre()
        {
            return nombre;
        }

        public void setapellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string getapellido()
        {
            return apellido;
        }

        public void setedad(int edad)
        {
            this.edad = edad;
        }

        public int getedad()
        {
            return edad;
        }

        public void setestadocivil(string estadocivil)
        {
            this.estadocivil = estadocivil;
        }

        public string getestadocivil()
        {
            return estadocivil;
        }

        public void setTiposangre(string Tiposangre)
        {
            this.Tiposangre = Tiposangre;
        }

        public string getTiposangre()
        {
            return Tiposangre;
        }

        public void setdireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string getdireccion()
        {
            return direccion;
        }
        public void Mostrar()
        {
            Console.WriteLine(getnombre() + getapellido() + getedad() +
            getdireccion() + getestadocivil() + getTiposangre());
        }
    }
}
