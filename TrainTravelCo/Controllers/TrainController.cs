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
    [Route("train")]
    [ApiController]
    public class TrainController : ControllerBase
    {

        private TrainManager _trainManager;

        public TrainController()
        {
            _trainManager = new TrainManager();
        }



        //[HttpGet("{trainId}")]
        //public List<Train> Get(int trainId)
        //{

        //}

        [HttpGet("train")]
        public Train GetTrain()
        {
            return _trainManager.GetTrain();
        }

        [HttpPost]
        public string BookTrain([FromBody] Train train)
        {
            bool success = _trainManager.MakeBooking(train);

            if (success)
            {
                return $"Booking Successful!";
            }
            return $"Booking Unsuccessful...";
        }
    }
}