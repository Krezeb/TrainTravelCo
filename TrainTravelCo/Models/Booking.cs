using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Models

{
    public class Booking
    {
        public Customer Customer { get; set; }
        public Trip Trip { get; set; }
    }
}
