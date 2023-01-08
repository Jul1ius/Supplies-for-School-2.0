using System;

namespace exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packetsPencils = int.Parse(Console.ReadLine());
            int packetsMarckers = int.Parse(Console.ReadLine());
            int litresPreparat = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pencilesCost = packetsPencils * 5.80;
            double markerCost = packetsMarckers * 7.20;
            double preparatCost = litresPreparat * 1.20;

            double totalCost = pencilesCost + markerCost + preparatCost;
            double totalWithDisocunt = totalCost - (totalCost * (0.01 * discount));
            Console.WriteLine(totalWithDisocunt);
        }
    }
}
