using Assignment8;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text.Json;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        string mealplan = @"F:\Amdaris\File System&Streams\Assignment8\MealPlan.txt";

        List<BlogPost> blogpost = new List<BlogPost>();

        using (StreamReader sr = new StreamReader(mealplan))
        {
            while (sr.EndOfStream == false)
            {
                string[] line = sr.ReadLine().Split(' ');
                if (line[1].Contains("PM"))
                {
                    blogpost.Add(new BlogPost(line[0], line[1], line[2]));
                }
            }


            StreamWriter sw = new StreamWriter(@"F:\Amdaris\File System&Streams\Assignment8\diet.txt");
            foreach (var b in blogpost)
            {
                sw.WriteLine(b.RecommendedTime + " " + b.BlogName);
            }
        }
        /*
        //Encrypt

        Aes aes = Aes.Create();
        
        FileStream fs = new FileStream(@"F:\Amdaris\File System&Streams\Assignment8\diet.txt", FileMode.OpenOrCreate);
        FileStream fsEncrypt = new FileStream(@"F:\Amdaris\File System&Streams\Assignment8\diet_encrypted.txt", FileMode.OpenOrCreate);
        CryptoStream cs = new CryptoStream(fsEncrypt, aes.CreateEncryptor(), CryptoStreamMode.Write);
                        
        fs.CopyTo(cs);
        
        
        //GZip

        FileStream fsCompress = new FileStream(@"F:\Amdaris\File System&Streams\Assignment8\diet_compressed.txt", FileMode.OpenOrCreate);
        GZipStream gs = new GZipStream(fsCompress, CompressionMode.Compress);
                
        fs.CopyTo(gs);
       
        //UnGzip
        
        using (FileStream reader = File.OpenRead(@"F:\Amdaris\File System&Streams\Assignment8\diet_compressed.txt"))
        using (GZipStream zip = new GZipStream(reader, CompressionMode.Decompress, true))
        using (StreamReader unzip = new StreamReader(zip))
        while (!unzip.EndOfStream)
        unzip.ReadLine();

        //decrypt
        
        FileStream fs2 = new FileStream(@"F:\Amdaris\File System&Streams\Assignment8\diet_encrypted.txt", FileMode.Open);
        CryptoStream cs2 = new CryptoStream(fs2, aes.CreateDecryptor(), CryptoStreamMode.Read);
        StreamReader reader2 = new StreamReader(cs2);
        string content=reader2.ReadToEnd();
        Console.WriteLine(content);
        
        */







    }
}

