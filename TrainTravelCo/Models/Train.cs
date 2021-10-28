using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Models

{
    public class Train
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatsWanted { get; set; }

        public int MaxCapacity { get; set; }
        public static int CurrentBookings { get; set; }


        private static int _idCounter = 0;

        public Train()
        {
            Id = _idCounter++;
        }
    }
}
