using System;
using System.IO;

namespace CLI_Tools;

public class Sed
{
    public static void RunSed(string[] args)
    {
        String file = args[^1];
        String searchTerm = args[1];
        String replaceTerm = args[2];
        String line;
        List<String> lines = new List<string>();
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(file);
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                if(line.Contains(searchTerm))
                {
                    string newLine = line.Replace(searchTerm, replaceTerm);
                    lines.Add(newLine);
                }
                else
                {
                    lines.Add(line);
                }
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            Console.ReadLine();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        try
        {
            StreamWriter sw = new StreamWriter(file);
            foreach(string l in lines)
            {
                sw.WriteLine(l);
            }
            sw.Close();
            Console.ReadLine();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        Console.ReadKey();
        return;
    }
}