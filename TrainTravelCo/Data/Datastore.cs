using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Data
{
    public class Datastore
    {
        private static Datastore _instance = null;
        private List<Train> _trains = new List<Train>();
        private Train _train;

        public Datastore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Datastore();
                }
                return _instance;
            }
        }

        public Datastore()
        {
            _train = new Train() 
            {
                MaxCapacity = 50
            };
        }

        public List<Train> List()
        {
            return _trains;
        }

        public bool Create(Train train)
        {
            _trains.Add(train);
            return true;
        }
        public List<Train> GetTrains()
        {
            return _trains;
        }
    }
}
