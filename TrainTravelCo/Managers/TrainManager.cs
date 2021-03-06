using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Managers
{
    public class TrainManager
    {
        public string AddTrain(Train newTrain)
        {
            DataStore.Instance.SaveTrain(newTrain);
            return $"New Train Added to \"Trains\" List.";
        }

        public List<Train> ListAllTrains()
        {
            return DataStore.Instance.ListAllTrains();
        }
    }
}

/*
 * 1.7
 * Koppla nu samman TrainController med TrainManager. 
 * Gör detta genom att skapa ett private fält av typen TrainManager i TrainController. 
 * Skapa sedan en konstruktor i TrainController som skapar en ny instans av TrainManager.
 * Med detta fält på plats kan vi nu få TrainController att skicka vidare anropen till 
 * create och list i TrainManager som i sin tur skickar vidare till DataStore.
 * 
 * Prova att köra programmet. 
 * Skapa ett tåg och lista sedan alla tåg. 
 * Har du gjort rätt kommer ditt tåg visas i listan.
 * 
 */ 