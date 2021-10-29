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
    [Route("booking")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private BookingManager _bookingManagerInstance;

        public BookingController()
        {
            _bookingManagerInstance = new BookingManager();
        }

        [HttpGet("search")]
        public List<Trip> Search(string origin)
        {
            return _bookingManagerInstance.Search(origin);
        }

        [HttpPost("booktrip")]
        public void BookTrip(int tripId, [FromBody]Customer customer)
        {
            _bookingManagerInstance.BookTrip(tripId, customer);
        }
    }
}

/*
 * 
 * 
 */ 