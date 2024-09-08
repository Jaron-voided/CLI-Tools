using System;
using System.IO;

namespace CLI_Tools;

public class Tools
{

    public static void ChooseTool(string[] args)
    {
        string command = args[0];
        switch (command) 
        {
        case "Awk":
            Awk.RunAwk(args);
            break;
        case "Grep":
            Grep.RunGrep(args);
            break;
        case "Ls":
            Ls.RunLS(args);
            break;
        case "Mkdir":
            Mkdir.RunMkdir(args);;
            break;
        case "Rmdir":
            Rmdir.RunRmdir(args);;
            break;
        case "Sed":
            Sed.RunSed(args);
            break;
        case "Touch":
            Touch.RunTouch(args);
            break;
        default:
            Console.WriteLine("Please enter a valid input.");
            break;
        }
    }
    public static string GetPath()
    {
        return Directory.GetCurrentDirectory();
    }

    public static string[] GetFiles(string path)
    {
        return Directory.GetFiles(path);
    }

    public static string[] GetDirectories(string path)
    {
        return Directory.GetDirectories(path);
    }

    public static string[] GetFullContents(string path)
    {
        string[] files = GetFiles(path);
        string[] directories =  GetDirectories(path);
        string[] fullContents = files.Concat(directories).ToArray();
        Array.Sort(fullContents);
        return fullContents;
    }

    public static string[] GetBriefContents(string[] fullContents)
    {
        string[] briefContents = new string[fullContents.Length];
        for (var i = 0; i < fullContents.Length; i++)
        {
            string[] contents = fullContents[i].Split('/');
            briefContents[i] = contents.Last();
        }
        return briefContents;
    }
}