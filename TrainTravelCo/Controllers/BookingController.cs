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
        public void BookTrip(BookTripDTO bookTripDto)
        {
            int tripId = bookTripDto.TripId;
            string customerName = bookTripDto.CustomerName;
            string customerPhone = bookTripDto.CustomerPhone;

            _bookingManagerInstance.BookTrip(tripId, customerName, customerPhone);
        }
    }
}

/*
 * 
 * 
 */ 