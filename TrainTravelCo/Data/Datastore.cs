using System.Collections.Generic;
using System;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Controllers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Data
{
    public class DataStore
    {
        private static DataStore _instance = null;

        public static DataStore Instance //SINGELTON - this Class is kept in memory and is the only version of this class that will be called.
        {
            get
            {
                if (_instance == null)
                {
                    return _instance = new DataStore();
                }
                return _instance;
            }
        }

        private List<Train> TrainList = new List<Train>();

        public string AddTrain(Train newTrain)
        {
            TrainList.Add(newTrain);
            return $"New Train Added to \"Trains\" List.";
        }

        public List<Train> ListAllTrains()
        {
            return TrainList;
        }
    }
}


/*
 * 1.4
 * Vi vill nu lägga till möjligeten att lista och skapa tåg via webben. 
 * Så skapa en controller som heter TrainController. 
 * Klassen ska hantera sökvägen /train. 
 * Skapa metoder med routings för skapa och lista tåg. 
 * Tänkt själv ut vilka attribut, parametrar och return-värden som ska användas.
 * 
 * Eftersom vi inte har något koppling mellan controller och data-lager än kan vi inte implementera metoderna ännu. 
 * Se deluppgift 1.6 för detta.
 * 
 */