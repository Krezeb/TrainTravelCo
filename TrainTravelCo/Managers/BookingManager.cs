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
                int maxCapacity = trip.Train.TrainMaxSeats;
                int bookedSeats = trip.Bookings.Count;

                if (origin == trip.Origin && bookedSeats < maxCapacity)
                {
                    searchResultList.Add(trip);
                }
            }
            return searchResultList;
        }

        public void BookTrip(int tripID, string name, string tel)
        {
            Customer newCustomer = new Customer()
            {
                Name = name,
                Tel = tel
            };

            Trip newTrip = GetTrip(tripID);

            int maxCapacity = newTrip.Train.TrainMaxSeats;
            int bookedSeats = newTrip.Bookings.Count;

            if (bookedSeats == maxCapacity)
            {
                throw new Exception("Train Fully Booked...");
            }

            Booking newBooking = new Booking()
            {
                Customer = newCustomer,
                Trip = newTrip
            };

            newTrip.Bookings.Add(newBooking);
        }

        public Trip GetTrip(int tripId)
        {
            List<Trip> tripList = DataStore.Instance.ListAllTrips();
            Trip newTrip = new Trip();
            newTrip = null;
            foreach (Trip aTrip in tripList)
            {
                if (tripId == aTrip.TripId)
                {
                    newTrip = aTrip;
                    return newTrip;
                }
            }
                throw new Exception($"Trip ID \"{tripId}\" not found...");
        }
    }
}

/*
 * 
 * 
 */ 