using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Managers
{
    public class TripManager
    {
        public string AddTrip(int trainId, string origin, string destination, string departureTime  )
        {
            var trainList = DataStore.Instance.ListAllTrains();
            
            foreach(Train train in trainList)
            {
                if (trainId == train.TrainId)
                {
                    var newTrip = new Trip()
                    {
                        TripTrainId = trainId,
                        Origin = origin,
                        Destination = destination,
                        DepartureTime = departureTime
                    };
                    DataStore.Instance.AddTrip(newTrip);
                    return $"New Trip Added to \"Trip\" List.";
                }
            }
            return $"No such Train found...";
        }

        public List<Trip> ListAllTrips()
        {
            return DataStore.Instance.ListAllTrips();
        }
    }
}

/*
 * 
 * 
 */ 