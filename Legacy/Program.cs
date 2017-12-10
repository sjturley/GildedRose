using System;
using System.Collections.Generic;
using Npgsql;

namespace Legacy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GildedRose.updateQuality();
        }
    }
}