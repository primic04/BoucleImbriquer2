using System;
using System.Collections.Generic;

namespace boucleimbriquer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("debut du test");

            Console.WriteLine("veux tu jouer avec moi");
            string useranswer = Console.ReadLine();


            if (useranswer == "oui")
            {
                Console.WriteLine("vous avez dit " + useranswer);
            }
            else if(useranswer == "non")
            {
                Console.WriteLine("vous avez repondu " + useranswer);
            }
            else
            {
                while (useranswer != "oui" || useranswer != "non")
                {
                    Console.WriteLine("veux tu jouer avec moi");
                    useranswer = Console.ReadLine();
                    if (useranswer == "oui")
                    {
                        Console.WriteLine("vous avez dit " + useranswer);
                        break;
                    }
                    else if (useranswer == "non")
                    {
                        Console.WriteLine("vous avez repondu " + useranswer);
                        break;
                    }
                    //else
                    //{
                        //continue;
                    //}                    
                }
            }
            Console.WriteLine("test reussis");
         




            Console.Read();
        }
    }
}

