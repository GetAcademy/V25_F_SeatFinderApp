using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatFinder
{
    internal class SeatFinderApp
    {
        private User _user;
        private List<Flight> _flights = new List<Flight>
        {
            new Flight("AB123", 10, 15, 30),
            new Flight("CD345", 20, 20, 40),
            new Flight("AS823", 40, 40, 60)
        };
        public void Run()
        {
            if (_user == null)
            {
                CreateUser();
            }
            while (true)
            {
                Menu();
            }
        }

        private void CreateUser()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            _user = new User(name, ChangePreference());
            Console.WriteLine(_user.Preference);
        }

        private void Menu()
        {
            Console.WriteLine($"""
                              Hey {_user.Name}!
                              Welcome to the SeatFinderApp - for your travels!
                              1) All current flights
                              2) Change preference
                              3) Book a flight
                              4) Exit
                              """);
            HandleInput();
        }

        private void HandleInput()
        {
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ShowAllFlights();
                    break;
                case "2":
                    _user.Preference = ChangePreference();
                    break;
                case "3":
                    // Velg en flyvning og booke
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
        }

        private void ShowAllFlights()
        {
            Console.WriteLine("All flights:");
            foreach (var flight in _flights)
            {
                Console.WriteLine($"""
                                   Flight: {flight.FlightNumber}
                                   Available {_user.Preference} seats: {flight.CountAvailableSeats(_user.Preference)}
                                   """);
            }
        }

        private SeatClass ChangePreference()
        {
            Console.WriteLine("Pick a preference:");
            foreach (var preference in Enum.GetValues<SeatClass>())
            {
                Console.WriteLine($"{(int)preference}) {preference}");
            }
            var isEnum = Enum.TryParse(Console.ReadLine(), out SeatClass enumResult);
            Console.WriteLine($"Preference set to {enumResult}");
            return enumResult;
        }
    }
}
