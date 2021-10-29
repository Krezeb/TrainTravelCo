using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;


namespace TrainTravelCo.Controllers
{
    [Route("trip")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private TripManager _tripManagerInstance;

        public TripController()
        {
            _tripManagerInstance = new TripManager();
        }

        [HttpPost ("create")]
        public string Create(int trainId, string origin, string destination, string departureTime)
        {
            return _tripManagerInstance.AddTrip(trainId, origin, destination, departureTime);
        }

        [HttpGet("getlist")]
        public List<Trip> GetTripList()
        {
            return _tripManagerInstance.ListAllTrips();
        }
    }
}

/*
 * 
 * 
 */ 