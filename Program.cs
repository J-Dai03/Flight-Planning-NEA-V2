using System;
using System.IO;
namespace Flight_Planning_NEA_V2
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Hello World!");
            
            //Load text file
            string AirportDataFile;
            AirportDataFile = File.ReadAllText("Airports.txt");
            Console.WriteLine(AirportDataFile);

            //Divide up text file
            string[] AirportDataLines = AirportDataFile.Split('\n');
            Console.WriteLine(AirportDataLines);
            int Lines = AirportDataLines.Length;
            Console.WriteLine(AirportDataLines);
            Console.WriteLine("Number of airports: " + Convert.ToString(Lines));

            //Create arrays and define their length

            string[] PortCode;
            string[] PortName;
            int[] DistanceFromLPL;
            int[] DistanceFromBOH;

            PortCode = new string[Lines];
            PortName = new string[Lines];
            DistanceFromLPL = new int[Lines];
            DistanceFromBOH = new int[Lines];

            //Input data into arrays

            for (int i = 0; i < Lines; i++)
            {
                string[] Fields = AirportDataLines[i].Split(",");
                PortCode[i] = Fields[0];
                Console.WriteLine(Convert.ToString(PortCode[i]));

                PortName[i] = Fields[1];
                Console.WriteLine(Convert.ToString(PortName[i]));

                DistanceFromLPL[i] = Convert.ToInt32(Fields[2]);
                Console.WriteLine(Convert.ToString(DistanceFromLPL[i]));

                Console.WriteLine(Convert.ToString(Fields[3]));

                DistanceFromBOH[i] = Convert.ToInt32(Fields[3]);
            }

        }
    }
}
