using System;
using System.Collections.Generic;
using System.IO;

namespace CSProject
{
    public class FileReader
    {
        public List<Staff> ReadFile()
        {
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string path = "staff.txt";
            string[] separator = { ", " };

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                    
                {
                    while (sr.EndOfStream != true)
                    {
                        path.Split();
                        if (result[1] == "Manager")
                        {
                            myStaff.Add(new Manager(result[2]));
                        }
                        else if (result[1] == "Admin")
                        {
                            myStaff.Add(new Admin(result[2]));
                        }
                    }
                    sr.Close();
                }
            }
            else if (!File.Exists(path))
            {
                Console.WriteLine("No input file exists");
            }
        }
    }
}
