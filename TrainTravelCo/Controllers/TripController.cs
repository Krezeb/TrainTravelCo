using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;
using TrainTravelCo_v2.DTO;

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
        public Trip CreateTrip(TripDTO tripDto)
        {
            string origin = tripDto.Origin;
            string destination = tripDto.Destination;
            int trainId = tripDto.TrainId;
            string departureTime = tripDto.DepartureTime;

            Trip newTrip = _tripManagerInstance.CreateTrip(trainId, origin, destination, departureTime);
            return newTrip;
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