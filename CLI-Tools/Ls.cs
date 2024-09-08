using System;
using System.IO;

namespace CLI_Tools;

public class Ls
{
    public static void RunLS(string[] args)
    {
        try
        {
            string path = Tools.GetPath();
            string[] fullContents = Tools.GetFullContents(path);
            string[] briefContents = Tools.GetBriefContents(fullContents);
            foreach(string briefContent in briefContents)
            {
                Console.WriteLine(briefContent);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}