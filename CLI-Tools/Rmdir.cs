using System;
using System.IO;

namespace CLI_Tools;

public class Rmdir
{
    public static void RunRmdir(string[] args)
    {
        try
        {
            string path = Tools.GetPath();
            string directoryName = args[1];
            string directoryPath = path + directoryName;
            // Determine whether the directory exists.
            if (Directory.Exists(directoryName))
            {
                Directory.Delete(directoryName);
            }
            Console.WriteLine("The directory was deleted successfully at {0}.", Directory.GetCreationTime(directoryName));
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}