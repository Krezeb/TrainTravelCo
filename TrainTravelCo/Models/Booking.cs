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
        public Customer Customer { get; init; }
        public Trip Trip { get; init; }
    }
}
