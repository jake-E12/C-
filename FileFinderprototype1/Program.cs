using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace FileFinderprototype1
{
    class Program
    {
        public static string defultpath = @"D:\";
        public static string rootPath = "";
        public static string extension;
        public static string path;
        public static string[] fileList;
        
        static void Main()
        {
            Console.WriteLine(@"Do you want to use defult root path(D:\): ");
            if (Console.ReadLine() == "y")
            {
                path = defultpath;
                FileFormat();
               
            }else
            {
                Console.WriteLine(@"What path do you want to use (e.g. D:\ ):" );
                path = Console.ReadLine();
                FileFormat();
            }
        }


        public static void FileFormat()
        {
            Console.WriteLine("What is the file called (please add extension e.g. example.txt): ");
            string file = Console.ReadLine();
            extension = Path.GetExtension(file);
            Dirsearch(path);
         
        }

        public static void Dirsearch(string sdir)
        {

            try
            {
                foreach (string d in Directory.GetDirectories(sdir))
                { 
                    foreach (string f in Directory.GetFiles(d, extension, SearchOption.AllDirectories))
                    {

                        if (extension != null && extension.Equals(extension))
                        {
                            fileList.Append(f);
                            Console.WriteLine(fileList);
                        }
                    }
                     Dirsearch(d);
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            
        }
    }
}
