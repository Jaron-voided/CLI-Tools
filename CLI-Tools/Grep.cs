using System;
using System.IO;

namespace CLI_Tools;

public class Grep
{
    public static void RunGrep(string[] args)
    {
        String file = args[^1];
        if (args.Length == 3)
        {
            String searchTerm = args[1];
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(file);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    if (line.Contains(searchTerm))
                        Console.WriteLine(line);
                    //Read the next line
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
        }
    }
}