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
        private TrainManager _trainManagerInstance;

        public TrainController()
        {
            _trainManagerInstance = new TrainManager();
        }

        [HttpPost ("create")]
        public string Create([FromBody]Train newTrain)
        {
            return _trainManagerInstance.AddTrain(newTrain);
        }

        [HttpGet("getlist")]
        public List<Train> GetTrainList()
        {
            return _trainManagerInstance.ListAllTrains();
        }
    }
}

/*
 * 
 * 
 */ 