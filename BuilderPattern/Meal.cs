﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Meal
    {
        private List<IItem> _items = new List<IItem>();

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;

            foreach (var item in _items)
            {
                cost += item.Price();
            }

            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in _items)
            {
                Console.WriteLine("Item: " + item.Name());
                Console.WriteLine("Packing: " + item.Packing().Pack());
                Console.WriteLine("Price: " + item.Price());
                Console.WriteLine();
            }
        }
    }
}
