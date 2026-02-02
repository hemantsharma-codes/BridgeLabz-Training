class UsingStatementForFileHandling
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter the path of file: ");
    string path = Console.ReadLine();

    try
    {
      using (StreamReader sr = new StreamReader(path))
      {
        string line = sr.ReadLine();
        Console.WriteLine(line);
      }
    }
    catch (IOException)
    {
      Console.WriteLine("Error reading File");
    }
  }
}