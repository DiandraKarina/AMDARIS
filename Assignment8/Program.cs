using Assignment8;
using System.Text.Json;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "Hello World!";
        byte[] compressed = GZip.CompressString(inputString);
        string decompressedString = GZip.DecompressToString(compressed);

        WriteLine($"Original:{inputString}");
        WriteLine($"Compressed:{JsonSerializer.Serialize(compressed)}");
        WriteLine($"Decompressed:{decompressedString}");


        string inputFile = @"C:\Users\Diandra\Desktop\Assignment8Test.txt";
        string gzipFile = @"C:\Users\Diandra\Desktop\Assignment8Test.txt.gz";

        if (File.Exists(inputFile)) { File.Delete(inputFile); }
        if (File.Exists(gzipFile)) { File.Delete(gzipFile); }
        File.WriteAllText(inputFile, "Write in my file");
        GZip.CompressFile(inputFile);

        WriteLine($"Original:{File.ReadAllText(inputFile)}");
        WriteLine($"Compressed:{JsonSerializer.Serialize(File.ReadAllBytes(gzipFile))}");
        File.Delete(inputFile);
        GZip.DecompressFile(gzipFile);
        WriteLine($"Decompressed:{File.ReadAllText(inputFile)}");
       

        try
        {
            string FileName = "test.txt";

            Console.WriteLine("Encrypt " + FileName);

            // Encrypt the file.
            Encryption.AddEncryption(FileName);

            Console.WriteLine("Decrypt " + FileName);

            // Decrypt the file.
            Encryption.RemoveEncryption(FileName);

            Console.WriteLine("Done");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        Console.ReadLine();
    }
}

