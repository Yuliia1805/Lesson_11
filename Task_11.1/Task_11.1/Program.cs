using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StreamWriter sw = new StreamWriter("1.txt", true);
            sw.WriteLine("Hello World");
            sw.Close();*/

            /*StreamReader sr = new StreamReader("1.txt");
            string line;
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                Console.WriteLine("************************");
                string[] array = line.Split();
                foreach (string str in array)
                {
                    Console.WriteLine(str);
                }
            }
            sr.Close();*/


            /*Console.WriteLine("Enter a string: ");
            string line = Console.ReadLine();
            string path = "file.txt";
            writeToFile(path, line);

            Console.WriteLine("From file: ");
            string output = readFromFile(path);
            Console.WriteLine(output);*/
           /* string path = "file.txt";
            string[] res = readArray(path);

            foreach(string str in res)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
        static void writeToFile(string path, string text)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(text);
            sw.Close();
        }
        
        static string readFromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string result = sr.ReadLine();
            sr.Close();
            return result;
        }
        /*static string[] readArray(string path)
        {
            string[] result;
            StreamReader sr = new StreamReader(path);
            int counter = 0;
            string line;

            while(sr.ReadLine() != null)
            {
                counter++;
            }
            sr.Close();
            StreamReader srNew = new StreamReader(path);
            result = new string[counter];

            counter = 0;
            while ((line = srNew.ReadLine()) != null)
            {
                result[counter] = line;
                counter++;
            }
            srNew.Close();
           
            return File.ReadAllLines(path); */

        }


        


    }
}
