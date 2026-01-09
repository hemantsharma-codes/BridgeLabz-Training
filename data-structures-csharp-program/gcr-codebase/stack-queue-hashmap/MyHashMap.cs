using System;
using System.Collections.Generic;

class MyHashMap
{
    private const int SIZE = 10;
    private LinkedList<Entry>[] buckets;

    // Key-Value pair class
    class Entry
    {
        public int Key;
        public int Value;

        public Entry(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    public MyHashMap()
    {
        buckets = new LinkedList<Entry>[SIZE];
        for (int i = 0; i < SIZE; i++)
            buckets[i] = new LinkedList<Entry>();
    }

    // Hash function
    private int GetIndex(int key)
    {
        return key % SIZE;
    }

    // Insert or Update
    public void Put(int key, int value)
    {
        int index = GetIndex(key);

        foreach (Entry entry in buckets[index])
        {
            if (entry.Key == key)
            {
                entry.Value = value; // update
                return;
            }
        }

        buckets[index].AddLast(new Entry(key, value));
    }

    // Retrieve
    public int Get(int key)
    {
        int index = GetIndex(key);

        foreach (Entry entry in buckets[index])
        {
            if (entry.Key == key)
                return entry.Value;
        }

        return -1; // key not found
    }

    // Delete
    public void Remove(int key)
    {
        int index = GetIndex(key);

        LinkedList<Entry> bucket = buckets[index];

        var current = bucket.First;
        while (current != null)
        {
            if (current.Value.Key == key)
            {
                bucket.Remove(current);
                return;
            }
            current = current.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        MyHashMap map = new MyHashMap();

        map.Put(1, 10);
        map.Put(11, 20); // collision with key 1
        map.Put(2, 30);

        Console.WriteLine(map.Get(1));   // 10
        Console.WriteLine(map.Get(11));  // 20

        map.Remove(1);
        Console.WriteLine(map.Get(1));   // -1
    }
}

