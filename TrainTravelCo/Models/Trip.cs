using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Models

{
    public class Trip
    {
        public int TripId { get; private set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DepartureTime { get; set; }
        public List <Booking> Bookings { get; set; }
        public Train Train { get; set; }
        
        private static int _idCounter = 0; //Is kept in memory and used every time the Train Class is called ("Static")

        public Trip()
        {
            TripId = _idCounter++;
            Bookings = new List<Booking>();
        }
    }
}

/*
 * 
 * 
 */ 