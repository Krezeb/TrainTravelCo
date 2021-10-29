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
        public int TripTrainId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DepartureTime { get; set; }
        public List <Booking> Booking { get; set; }
        
        private static int _idCounter = 0; //Is kept in memory and used every time the Train Class is called ("Static")

        public Trip()
        {
            TripId = _idCounter++;
            Booking = new List<Booking>();
        }
    }
}

/*
 * 
 * 
 */ 