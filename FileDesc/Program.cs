using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO; // used to get access to file streams.
using System.Linq; // used to get access to array.contains.

namespace FileDesc
{
    class Program
    {
        public static string Rootpath = @""; // the root path with @ so it does not get a error
        public static string[] Options = { "ls", "lf", "lfs", "df" }; // choses as a array used for error checking.
        static void Main()
        {
            Console.WriteLine("Enter your file path: "); // prompting user to imput a directory.
            Rootpath = Console.ReadLine(); // getting and setting the root path.

            if (Directory.Exists(Rootpath)) // checking if the path is valid.
            {
                Console.WriteLine($"Your chosen file path is {Rootpath}, if you do not want to use this please type n if its ok then press y"); // asking the user if they want to use this path or not.
                if (Console.ReadLine() == "n") // checking if the input is no. 
                {
                    Console.WriteLine("Enter your new file path: "); // prompting the user to give a new path.
                    Rootpath = Console.ReadLine(); // seeting new root path.
                    Choose(); // calling the choose method.
                }
                else // if the input is not n then call choose.
                {
                    Choose();
                }
            }
            else // telling the user that there path is valid.
            {
                Console.WriteLine("Please enter a valid path!");
            }
        }



        public static void Choose()
        {
            Console.WriteLine("-----------------------------------------------------------"); // used for GUI effect.
            Console.WriteLine("To list dir -- ls \n" +
                "To list files -- lf \n" +
                "To list files and size -- lfs \n" +
                "To delete temp files -- df \n"); // prompting the user to choose a function.
            string choose = Console.ReadLine(); // assigning the varible choose to user input.
            if (choose == "ls")
            {
                ListDir();
            }
            if (choose == "lf")
            {
                ListFile();
            }
            if (choose == "lfs")
            {
                FileSize();
            }
            if (choose == "df")
            {
                RemoveTempFiles();
            }
            if (!Options.Contains(choose))// checking if the user has put something that is not a choice and telling the user that there choice is not valid.
            {
                Console.WriteLine("Please choose a valid option.");
            }
        }
        public static void ListDir() // lisiting direcory method.
        {
            foreach (string elm in Directory.GetDirectories(Rootpath)) // looping directories inside of the root path.
            {
                Console.WriteLine($"Directory: {Path.GetFileName(elm)}"); // outputting the direcories found.
            }
        }

        public static void ListFile()// lisitng files method.
        {
            foreach (string d in Directory.GetDirectories(Rootpath)) // looping direcories inside of rootpath.
            {
                foreach (string f in Directory.GetFiles(d))// looping files inside of direcory from the loop.
                {
                    Console.WriteLine($"File name: {Path.GetFileName(f)}"); // outputting file name without path.
                }
            }
        }

        public static void FileSize()// file size method.
        {
            foreach (string d in Directory.GetDirectories(Rootpath)) // looping direcoties inside of rootpath.
            {
                foreach (string f in Directory.GetFiles(d)) // looping files inside of the direcory loop.
                {
                    FileInfo info = new FileInfo(f); // assigning new fileinfo for every file.
                    Console.WriteLine($"File name: {Path.GetFileName(f)} - File Size: {info.Length}"); // outputting file name and size.
                }
            }
        }
        public static void RemoveTempFiles()// removing files that are o bytes method.
        {
            foreach (string d in Directory.GetDirectories(Rootpath))// looping direcotries in root path.
            {
                foreach (string f in Directory.GetFiles(d))// looping files inside of dircory.
                {
                    FileInfo info = new FileInfo(f);// assigning file info to file.
                    if (info.Length <= 0)// checking if the file is less then 0 bytes.
                    {
                        Console.WriteLine($"deleting: {Path.GetFileName(f)}");// outputtin the deleting file.
                        File.Delete(f); // deleting the file.
                    }
                    else// checking if there is any files that are under 0 bytes if not then output an message.
                    {
                        Console.WriteLine("No temp file found.");
                    }
                }
            }
        }
    }
}
