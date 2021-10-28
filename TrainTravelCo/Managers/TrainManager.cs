using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Managers
{
    public class TrainManager
    {
        public bool MakeBooking(Train train)
        {
            if (Train.CurrentBookings + train.SeatsWanted <= train.MaxCapacity)
            {
                return true;
            }
            return false;
        }

        public Train GetTrain()
        {
            return _trains.GetTrains();

        }

    }
}
