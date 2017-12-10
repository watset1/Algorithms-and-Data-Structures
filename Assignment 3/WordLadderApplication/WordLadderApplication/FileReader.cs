using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLadderApplication
{
    //Static class to read in text file and output it as a list of strings
    public static class FileReader
    {
        public static List<String> ReadTxtFile(String file)
        {
            List<String> stringList = new List<string>();
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() >= 0)
                    {
                        stringList.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return stringList;
        }
    }
}
