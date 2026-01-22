using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.csharp_streams
{
    class FileCopyPerformance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter source file path:");
            string sourcePath = Console.ReadLine();

            Console.WriteLine("Enter destination path for normal copy:");
            string normalDest = Console.ReadLine();

            Console.WriteLine("Enter destination path for buffered copy:");
            string bufferedDest = Console.ReadLine();

            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            long normalTime = CopyUsingFileStream(sourcePath, normalDest);
            long bufferedTime = CopyUsingBufferedStream(sourcePath, bufferedDest);

            Console.WriteLine("\n---- Performance Result ----");
            Console.WriteLine("Normal FileStream Time   : " + normalTime + " ms");
            Console.WriteLine("BufferedStream Time     : " + bufferedTime + " ms");

            if (bufferedTime < normalTime)
            {
                Console.WriteLine("BufferedStream is faster.");
            }
            else
            {
                Console.WriteLine("FileStream is faster.");
            }
        }

        // Utility method: Copy using normal FileStream
        static long CopyUsingFileStream(string source, string destination)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            FileStream readStream = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream writeStream = new FileStream(destination, FileMode.Create, FileAccess.Write);

            byte[] buffer = new byte[4096];
            int bytesRead;

            while ((bytesRead = readStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
            }

            readStream.Close();
            writeStream.Close();

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        // Utility method: Copy using BufferedStream
        static long CopyUsingBufferedStream(string source, string destination)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            FileStream readFile = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream writeFile = new FileStream(destination, FileMode.Create, FileAccess.Write);

            BufferedStream readStream = new BufferedStream(readFile, 4096);
            BufferedStream writeStream = new BufferedStream(writeFile, 4096);

            byte[] buffer = new byte[4096];
            int bytesRead;

            while ((bytesRead = readStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
            }

            writeStream.Flush();

            readStream.Close();
            writeStream.Close();
            readFile.Close();
            writeFile.Close();

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }

}
