using System;
using System.Collections.Generic;


namespace recount
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, int> candidateNameCount = new Dictionary<string, int>();

            int Winners = -1;
            string WinningName = "";
            int tieCount = 0;

            string currentName = Console.ReadLine();

            
            while (currentName != "***")
            {
               
                if (!candidateNameCount.ContainsKey(currentName))
                {
                    candidateNameCount.Add(currentName, 1);
                }

                else
                {

                    candidateNameCount[currentName] += 1;
                }


                
                if (candidateNameCount[currentName] > Winners)
                {
                    
                    Winners = candidateNameCount[currentName];
                    WinningName = currentName;
                    tieCount = 0;
                }
               
                else if (candidateNameCount[currentName] == Winners)
                {
                 
                    tieCount += 1;
                }

                currentName = Console.ReadLine();
            }


            if (tieCount > 0)
            {
                Console.WriteLine("Runoff!");
            }
            else
            {
                Console.WriteLine(WinningName);
            }

          

        }
    }
}