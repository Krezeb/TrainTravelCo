﻿using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Data
{
    public class DataStore
    {
        private static DataStore _instance = null;

        public static DataStore Instance //SINGELTON - this Class is kept in memory and is the only version of this class that will be called.
        {
            get
            {
                if (_instance == null)
                {
                    return _instance = new DataStore();
                }
                return _instance;
            }
        }

        private DataStore()
        {
            _trainList.Add(new Train { TrainMaxSeats = 25, TrainRegNum = "Train-01" });
            _trainList.Add(new Train { TrainMaxSeats = 50, TrainRegNum = "Train-02" });
            _tripsList.Add(new Trip { Origin = "Aberdeen", Destination = "Glasgow", DepartureTime = "06:00", TripTrainId = 0 });
            _tripsList.Add(new Trip { Origin = "Örebro", Destination = "Stockholm", DepartureTime = "10:00", TripTrainId = 1 });
            _tripsList.Add(new Trip { Origin = "Paris", Destination = "Munich", DepartureTime = "13:00", TripTrainId = 0 });
            //new Booking { Customer = { Name = "Lac", Tel = "123456789" }, Trip = { Origin = "Paris", Destination = "Munich", DepartureTime = "13:00" } };
        }

        //---------------------------------------------------------------------------------------------

        private List<Train> _trainList = new List<Train>();

        public void AddTrain(Train newTrain)
        {
            _trainList.Add(newTrain);
        }

        public List<Train> ListAllTrains()
        {
            return _trainList;
        }

        //---------------------------------------------------------------------------------------------

        private List<Trip> _tripsList = new List<Trip>();

        public void AddTrip(Trip newTrip)
        {
            _tripsList.Add(newTrip);
        }

        public List<Trip> ListAllTrips()
        {
            return _tripsList;
        }
    }
}


/*
 * 
 * 
 */