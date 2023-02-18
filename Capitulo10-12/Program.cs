using System;

namespace Capitulo10_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int lado = 20;

            Depuracion d1 = new Depuracion();
            Inventario d2 = new Inventario();
            Poligono d3 = new Poligono(lado);

            do
            {

                Console.Write("\n -----------MENU-----------\n\n");
                Console.Write("\n ---Selecciona una opcion: ");
                Console.Write("\n 1) Capitulo # 10 ");
                Console.Write("\n 2) Capitulo # 10 Poligono");
                Console.Write("\n 3) Capitulo # 12 ");
                Console.Write("\n 4) Salir\n\n ");

                opcion = Int16.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        d2.visualizar();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        d3.calcular();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        d1.factorial();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        break;
                }

            } while (opcion != 4);
        }
    }
}
