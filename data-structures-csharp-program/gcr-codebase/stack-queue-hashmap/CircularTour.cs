using System;
using System.Collections.Generic;

class PetrolPump
{
    public int Petrol;
    public int Distance;

    public PetrolPump(int petrol, int distance)
    {
        Petrol = petrol;
        Distance = distance;
    }
}

class CircularTour
{
    static int FindStartingPoint(PetrolPump[] pumps)
    {
        Queue<int> queue = new Queue<int>();
        int surplus = 0;
        int start = 0;

        for (int i = 0; i < pumps.Length; i++)
        {
            surplus += pumps[i].Petrol - pumps[i].Distance;
            queue.Enqueue(i);

            // If petrol becomes insufficient
            while (surplus < 0 && queue.Count > 0)
            {
                int removedIndex = queue.Dequeue();
                surplus -= pumps[removedIndex].Petrol - pumps[removedIndex].Distance;
                start = removedIndex + 1;
            }
        }

        return queue.Count == pumps.Length ? start : -1;
    }

    static void Main()
    {
        PetrolPump[] pumps =
        {
            new PetrolPump(6, 4),
            new PetrolPump(3, 6),
            new PetrolPump(7, 3)
        };

        int startPoint = FindStartingPoint(pumps);

        if (startPoint == -1)
            Console.WriteLine("Circular tour is not possible");
        else
            Console.WriteLine("Start tour from petrol pump index: " + startPoint);
    }
}

