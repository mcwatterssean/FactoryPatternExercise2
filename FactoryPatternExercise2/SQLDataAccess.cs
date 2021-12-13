﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){ Name = "Xbox", Price = 350},
            new Product(){ Name = "Guitar", Price = 1000},
            new Product(){ Name = "Blender", Price = 50},
            new Product(){ Name = "Kite", Price = 25},
        };


        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data Access.");

            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL Data Access");
        }
    }
}
