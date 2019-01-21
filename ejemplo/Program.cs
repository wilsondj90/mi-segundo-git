using System;
using System.Collections.Generic;
using System.Text;

namespace Maquina_Chocolates
{
    class Productos
    {


        public int menu()
        {

            int[] produ = new int[5];
            int product, cantidad;
            string bandera = "si";
            int total = 0;

            while (bandera == "si")

            {
                Console.WriteLine("¿Que producto desea comprar:? \n" +
                                  "1.Chocolatina golpe $ 1500. \n" +
                                  "2.Detodito BBQ $ 1900. \n" +
                                  "3.Chitos picantes $ 1300. \n" +
                                  "4.Gaseosa cocacola $ 2500. \n" +
                                  "5.Pandebono $ 2500.");
                product = int.Parse(Console.ReadLine());

                Console.WriteLine("¿Cuantos productos desea comprar?");
                cantidad = int.Parse(Console.ReadLine());

                switch (product)
                {

                    case 1:

                        produ[0] = 1500 * cantidad;

                        break;

                    case 2:

                        produ[1] = 1900 * cantidad;

                        break;

                    case 3:

                        produ[2] = 1300 * cantidad;

                        break;

                    case 4:

                        produ[3] = 2500 * cantidad;

                        break;

                    case 5:

                        produ[4] = 2500 * cantidad;

                        break;

                    default:

                        Console.WriteLine("Codigo errado");

                        break;
                }

                Console.WriteLine("¿Desea comprar otro producto?: si/no");
                bandera = Console.ReadLine();

            }


            total = produ[0] + produ[1] + produ[2] + produ[3] + produ[4];
            return total;

        }





    }
}
