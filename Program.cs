﻿using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0,
                kidTickets = 0,
                standardTickets = 0,
                totalTickets = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Finish")
                {
                    break;
                }
                string movieName = command;
                int hallCapacity = int.Parse(Console.ReadLine());
                int soldTikets = 0;

                for (int i = 0; i < hallCapacity; i++)
                {
                    string ticketCommand = Console.ReadLine();
                    if (ticketCommand == "End")
                    {
                        break;
                    }
                    switch (ticketCommand)
                    {
                        case "standard": standardTickets++; break;
                        case "student": studentTickets++; break;
                        case "kid": kidTickets++; break;

                    }
                    totalTickets++;
                    soldTikets++;
                }
                Console.WriteLine($"{movieName} - {(soldTikets * 1.0 / hallCapacity) * 100:f2}% full.");

            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTickets * 1.0 / totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardTickets * 1.0 / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidTickets * 1.0 / totalTickets) * 100:f2}% kids tickets.");
        }

    }
}
