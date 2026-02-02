using System;
using System.IO;
class FileNotFoundDemo
{
  static void Main(string[] args)
  {
    string fileName = "data.txt";

    try
    {
      string content = File.ReadAllText(fileName);
      Console.WriteLine("File Contents:");
      Console.WriteLine(content);
    }
    catch (IOException)
    {
      Console.WriteLine("File not found");
    }
  }
}