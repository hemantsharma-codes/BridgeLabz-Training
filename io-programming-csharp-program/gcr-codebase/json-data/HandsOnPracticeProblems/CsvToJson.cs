using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class CsvToJson
{
    static void Main()
    {
        string csvFile = "data.csv";
        if (!File.Exists(csvFile))
        {
            Console.WriteLine("CSV file not found");
            return;
        }

        string[] lines = File.ReadAllLines(csvFile);
        string[] headers = lines[0].Split(',');

        List<Dictionary<string, string>> csvData = new List<Dictionary<string, string>>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');
            Dictionary<string, string> record = new Dictionary<string, string>();
            for (int j = 0; j < headers.Length; j++)
            {
                record[headers[j]] = values[j];
            }
            csvData.Add(record);
        }

        string json = JsonConvert.SerializeObject(csvData, Formatting.Indented);
        Console.WriteLine(json);
    }
}
