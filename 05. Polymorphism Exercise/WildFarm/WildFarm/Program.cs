﻿using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                Animal animal = AnimalFactory.Create(command.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                animals.Add(animal);
                Console.WriteLine(animal.ProduceSound());
                Food food = FoodFactory.Create(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

                try
                {
                    animal.EatFood(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
