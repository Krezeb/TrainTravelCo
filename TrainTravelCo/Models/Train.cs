using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Models

{
    public class Train
    {
        public int TrainId { get; private set; }
        public string TrainRegNum { get; set; }
        public int TrainMaxSeats { get; set; }
        
        private static int _idCounter = 0; //Is kept in memory and used every time the Train Class is called ("Static")

        public Train()
        {
            TrainId = _idCounter++;
        }
    }
}
