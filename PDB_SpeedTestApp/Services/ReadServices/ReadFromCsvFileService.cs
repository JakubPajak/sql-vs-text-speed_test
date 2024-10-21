using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Services.ReadServices
{
    internal class ReadFromCsvFileService
    {
        public ReadFromCsvFileService()
        {
        }

        public double ReadFromCsvFile(int amount)
        {
            List<string> retrievedData = new List<string>();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "PDB");
            string filePath = Path.Combine(folderPath, "CsvFileTest.csv");

            Stopwatch sw = new Stopwatch();

            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    sw.Start();
                    //while (!streamReader.EndOfStream)
                    for(int i = 0; i < amount; i++) 
                    {
                        retrievedData.Add(streamReader.ReadLine());
                    }
                    sw.Stop();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1;
            }

            return sw.Elapsed.TotalMilliseconds;
        }
    }
}
