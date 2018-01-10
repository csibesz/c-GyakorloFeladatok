using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka
{
    class Parameters
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write(args[i]);
                }
               

            string first_param = "";
            string second_param = "";

            string[] nevlista = new string[]
            {
                "Joli","Dezső","Rezső","Gizi","Mari","Feri","Peti"
            };

            string[] leiras = new string[]
            {
                "Joli egy Botpaládi 76 éves lakos.",
                "Dezső egy Botpaládi 23 éves lakos.",
                "Rezső egy Botpaládi 42 éves lakos.",
                "Gizi egy Botpaládi 66 éves lakos.",
                "Mari egy Botpaládi 14 éves lakos.",
                "Feri egy Botpaládi 5 éves lakos.",
                "Peti egy Botpaládi 52 éves lakos."

            };

            if (args.Length!=0)
                first_param = args[0];

            if (args.Length != 0 && args.Length != 1)
                second_param = args[1];


            switch (first_param)
            {
                case "\\NameList":
                    {
                        foreach (string item in nevlista)
                        {
                            Console.Write(item + " ");
                        }
                        break;
                    }
                case "\\WhoIs":
                    {

                        switch (second_param)
                        {
                            case "Joli":
                                Console.WriteLine(leiras[0]); break;
                            case "Dezső":
                                Console.WriteLine(leiras[1]); break;
                            case "Rezső":
                                Console.WriteLine(leiras[2]); break;
                            case "Gizi":
                                Console.WriteLine(leiras[3]); break;
                            case "Mari":
                                Console.WriteLine(leiras[4]); break;
                            case "Feri":
                                Console.WriteLine(leiras[5]); break;
                            case "Peti":
                                Console.WriteLine(leiras[6]); break;
                            default:
                                Console.WriteLine("Második paraméter, így nem tudom lekérni a személyt");
                                break;
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Nincs ilyen paraméter!"); break;
            }

            Console.ReadKey();
        }
    }
}
