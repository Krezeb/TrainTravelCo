using System.Collections.Generic;
using TrainTravelCo.Models;

namespace TrainTravelCo_v2.DTO
{
    public class ResponseDTO
    {
        public int TripId { get; init; }
        public string Origin { get; init; }
        public string Destination { get; init; }
        public string DepartureTime { get; init; }
        public List<Customer> Customers { get; init; }
        public int TrainId { get; init; }
    }
}
