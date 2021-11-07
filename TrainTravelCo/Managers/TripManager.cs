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
        public Trip CreateTrip(int trainId, string origin, string destination, string departureTime)
        {
            Train train = GetTrain(trainId);
            var newTrip = new Trip()
            {
                Origin = origin,
                Destination = destination,
                DepartureTime = departureTime,
                Train = train
            };
            DataStore.Instance.SaveTrip(newTrip);
            return newTrip;
        }

        private Train GetTrain(int trainId)
        {
            Train train = null;
            var trainList = DataStore.Instance.ListAllTrains();

            foreach (Train atrain in trainList)
            {
                if (trainId == atrain.TrainId)
                {
                    train = atrain;
                    break;
                }
            }
            if (train == null)
            {
                throw new Exception($"No such Train with TrainID {trainId} found...");
            }
            return train;
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