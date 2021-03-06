﻿using System;
using WorkshopEnumGenerics.TwentyPlusOne;

namespace WorkshopEnumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise01_ParkingLot();
            Exercise02_TwentyPlusOne();
            Console.ReadKey();
        }

        private static void Exercise02_TwentyPlusOne()
        {
            GameServer gameServer = new GameServer();
            GameClient gameClient = new GameClient(gameServer);
            gameClient.Play();
        }

        private static void Exercise01_ParkingLot()
        {
            ParkingLot parkingLot = new ParkingLot();
            Console.WriteLine(parkingLot);
            Console.WriteLine();
            Console.WriteLine(parkingLot.ColorsOfParkingCars);
            Console.WriteLine();
            Console.WriteLine(parkingLot.TypesOfParkingCars);
            Console.WriteLine();
            Console.WriteLine(parkingLot.ColorsAndTypesOfParkingCars);
            Console.WriteLine();
            Console.WriteLine(parkingLot.MostFrequentCar);
        }
    }
}
