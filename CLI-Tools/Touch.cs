using System;
using System.IO;

namespace CLI_Tools;

public class Touch
{
    public static void RunTouch(string[] args)
    {
        try
        {
            string path = Tools.GetPath();
            string fileName = args[1];
            string filePath = path + fileName;
            using (FileStream fs = File.Create(filePath))
            Console.WriteLine($"The file {fileName} has been created at {path}");
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}