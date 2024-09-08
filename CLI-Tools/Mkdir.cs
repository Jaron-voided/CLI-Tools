using System;
using System.IO;

namespace CLI_Tools;

public class Mkdir
{
    public static void RunMkdir(string[] args)
    {
        try
        {
            string path = Tools.GetPath();
            string directoryName = args[1];
            string directoryPath = $"{path}/{directoryName}";
            // Determine whether the directory exists.
            if (Directory.Exists(directoryName))
            {
                Console.WriteLine("That path exists already.");
                return;
            }

            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(directoryName));
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}