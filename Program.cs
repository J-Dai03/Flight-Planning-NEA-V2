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

            Menu();


        }
        
        //Check if in array
        static bool IfInArray(string[] data, string item)
        {
            int N=data.Length;
            for (int i=0; i < N; i++)
                if (data[i] == item)
                    return true;
            return false;
        }
        //Check where in array
        static int WhereInArray(string[] data, string item)
        {
            int N=data.Length;
            for (int i=0; i < N; i++)
                if (data[i] == item)
                    return i;
            Console.WriteLine("Item not found in array");
            return-1;
        }



        //Complex ops
        //    ||
        //    ||
        //   _||_
        //   \  /
        //    \/
        static void EnterAirports()
        {
            Console.WriteLine("Enter airport details selected");
            Console.WriteLine("Enter code for UK airport (BOH or LPL)");
            UKport = Console.ReadLine();
            if ((UKport != "BOH") && (UKport != "LPL"));
		    {
                Console.WriteLine("Invalid entry");
                UKport = "";
                break;
            }

            Console.WriteLine("Enter code for overseas airport");
            OVSport = Console.ReadLine();
            if (!(IfInArray(PortCode, OVSport)));
            {
		        Console.WriteLine("Invalid entry");
                OVSport = "";
                break;
            Console.WriteLine(PortName[WhereInArray(PortCode, OVSport)]);
            }
	    }

        static void Menu()
        {
	        int choice;
            Console.WriteLine("Menu:");
            Console.WriteLine("Please enter a number from 1 to 5 to make your selection");
            Console.WriteLine("1: Enter airport details");
            Console.WriteLine("2: Enter flight details");
            Console.WriteLine("3: Enter price plan & calculate profit");
            Console.WriteLine("4: Clear data");
            Console.WriteLine("5: Quit");
            choice = Console.Readline;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Option 1 selected");
                    EnterAirports();
                    break;

                case 2:
                    Console.WriteLine("Enter flight details selected");
                break;

                case 3:
                    Console.WriteLine("Enter price plan and calculate profit selected");
                    break;

                case 4:
                    Console.WriteLine("Clear data");
                    break;

                case 5:
                    Console.WriteLine("Quitting");
                    break;

                    default:
                    Console.WriteLine("Invalid input. Try again");
                    break;
            }
        }

    }
}
