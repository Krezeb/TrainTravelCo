using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Managers
{
    public class BookingManager
    {
        public List<Trip> Search(string origin)
        {
            var tripList = DataStore.Instance.ListAllTrips();

            List<Trip> searchResultList = new List<Trip>();

            foreach (Trip trip in tripList)
            {
                if (origin == trip.Origin)
                {
                    searchResultList.Add(trip);
                }
            }
            return searchResultList;
        }

        public void BookTrip(int tripID, Customer customer)
        {
            var tripList = DataStore.Instance.ListAllTrips();

            foreach (Trip trip in tripList)
            {
                if (tripID == trip.TripId)
                {
                    var booking = new Booking 
                    { 
                        Customer = customer, 
                        Trip = trip 
                    };
                }
            }
        }
    }
}

/*
 * 
 * 
 */ 