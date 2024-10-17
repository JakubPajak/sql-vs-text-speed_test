using PDB_SpeedTest.Models;
using PDB_SpeedTest.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Services.WriteServices
{
    internal class WriteToCsvFileService
    {
        public WriteToCsvFileService()
        {

        }
        public double WriteToCsvFile(int amount)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "PDB");
            string filePath = Path.Combine(folderPath, "WriteToFileAsync.csv");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            GenerateDummyDataService generateDummyData = new GenerateDummyDataService();

            Stopwatch sw = new Stopwatch();
            double elapsedTime = 0;
            List<BasicDataDto> data = generateDummyData.GenerateDummyData(amount);

            // Zapis do pliku CSV
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                sw.Start();

                // Zapis nagłówków kolumn
                writer.WriteLine("Id,Name,Surname,DateOfBirth,Phone");

                foreach (var item in data)
                {
                    string line = $"{item.Name},{item.Surname},{item.DateOfBirth},{item.Phone}";
                    writer.WriteLine(line);
                }

                sw.Stop();
            }

            elapsedTime = sw.Elapsed.TotalMilliseconds;
            return elapsedTime;
        }
    }
}
