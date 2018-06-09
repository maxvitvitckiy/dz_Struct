using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    
    struct Train
    {
        public string destination;
        public int trainNumber;
        public string depTime;
    }
    class Program
    {
        static Train AddTrain()
        {
            Train newTr;
            Console.Write("Destination: ");
            newTr.destination = Console.ReadLine();
            Console.Write("Train number: ");
            int.TryParse(Console.ReadLine(), out (newTr.trainNumber));
            Console.Write("Departure time: ");
            newTr.depTime = Console.ReadLine();
            Console.WriteLine();
            return newTr;
        }
        static int Comp(Train t1, Train t2)
        {
            return t1.trainNumber.CompareTo(t2.trainNumber);
        }
        static void SortTrains(Train[] Trains)
        {
            Array.Sort(Trains, Comp);
        }

        static void ShowOneTrain(Train Train)
        {
            Console.WriteLine("Destination: " + Train.destination);
            Console.WriteLine("Train number: " + Train.trainNumber);
            Console.WriteLine("Departure time: " + Train.depTime);
            Console.WriteLine();

        }
        static void DrawLine()
        {
            Console.WriteLine(new string('_', 80));
            Console.WriteLine();
        }
        static void ShowTrains(Train[] Trains)
        {
            for (int i = 0; i < Trains.Length; i++)
            {
                ShowOneTrain(Trains[i]);
            }
        }

        static void FindTrain(Train[] Trains)
        {
            Console.Write("Find by train number: ");
            int trainNum;
            int.TryParse(Console.ReadLine(), out (trainNum));
            for (int i = 0; i < Trains.Length; i++)
            {
                if (Trains[i].trainNumber == trainNum) ShowOneTrain(Trains[i]);
            }
        }

        static void Main(string[] args)
        {
            int length = 2;
            Train[] Trains = new Train[length];
            for (int i = 0; i < length; i++)
            {
                Trains[i] = AddTrain();
            }
            SortTrains(Trains);
            DrawLine();
            ShowTrains(Trains);
            DrawLine();
            FindTrain(Trains);
            Console.ReadLine();
        }
    }
}
