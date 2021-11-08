using System;

namespace Task2
{
    struct Train
    {
        string destination, departureTime;
        int trainNumber;
        public Train(int trainNumber, string destination, string departureTime)
        {
            this.trainNumber = trainNumber;
            this.destination = destination;
            this.departureTime = departureTime;
        }
        public int TrainNumber
        {
            get
            {
                return trainNumber;
            }
        }
        public string Destination
        {
            get
            {
                return destination;
            }
        }
        public string Departure
        {
            get
            {
                return departureTime;
            }
        }

    }
    class Program
    {
        static Train[] SortByNumber(Train[]array)
        {
            Train temporary;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].TrainNumber > array[j].TrainNumber)
                    {
                        temporary = array[i];
                        array[i] = array[j];
                        array[j] = temporary;
                    }
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            // Create Train
            {
                for (int i = 0; i < trains.Length; i++)
                {
                    bool numberInput = false;
                    int trainNumber = 0;
                    while (!numberInput)
                    {
                        Console.Write($"Enter {i + 1} train number: ");
                        numberInput = int.TryParse(Console.ReadLine(), out trainNumber);
                        if (!numberInput)
                        {
                            Console.WriteLine("Incorrect Number! Please, use only numerical symbols.");
                        }
                    }
                    Console.Write($"Enter {i + 1} train destination point: ");
                    string destination = Console.ReadLine();
                    Console.Write($"Enter {i + 1} train departure time: ");
                    string departureTime = Console.ReadLine();

                    trains[i] = new Train(trainNumber, destination, departureTime);
                }
            }
            // Sort Train by Number;
            Train[] sortedTrains = SortByNumber(trains);
            // Sorting test
            for (int i = 0; i < sortedTrains.Length; i++)
            {
                Console.WriteLine($"Number: {sortedTrains[i].TrainNumber}, Destination: {sortedTrains[i].Destination}," +
                    $" Departure: {sortedTrains[i].Departure}");
            }
            //User search
            {
                bool searchAgain = true;
                while (searchAgain)
                {
                    bool userInput = false;
                    int searchNumber = 0;
                    while (!userInput)
                    {
                        Console.WriteLine("Enter train number to search:");
                        userInput = int.TryParse(Console.ReadLine(), out searchNumber);
                        if (!userInput)
                        {
                            Console.WriteLine("Please, enter a correct train number.");
                        }
                    }
                    bool trainFound = true;
                    for (int i = 0; i < sortedTrains.Length; i++)
                    {
                        if (searchNumber == sortedTrains[i].TrainNumber)
                        {
                            Console.WriteLine($"Train number: {sortedTrains[i].TrainNumber}, Destination: {sortedTrains[i].Destination}," +
                        $" Departure: {sortedTrains[i].Departure}");
                            trainFound = true;
                            break;
                        }
                        else
                        {
                            trainFound = false;
                        }
                    }
                    if (!trainFound)
                    {
                        Console.WriteLine($"Train number: {searchNumber} not found");
                    }

                    Console.WriteLine("Search again? (y - YES/n - NO)");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                        searchAgain = true;
                    else if (answer == "n")
                        searchAgain = false;
                    else
                        searchAgain = false;
                }
            }
            Console.ReadKey();
        }
    }
}
