using PDB_SpeedTest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bogus;
using Bogus.DataSets;
using System.Threading;
using System.Diagnostics;

namespace PDB_SpeedTest.Services
{
    internal class WriteToTextFileService
    {
        public WriteToTextFileService()
        { }

        public double WriteToTextFile(int amount)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "PDB");
            string filePath = Path.Combine(folderPath, "WriteToTextFile.txt");
            
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }


            GenerateDummyDataService generateDummyData = new GenerateDummyDataService();

            Stopwatch sw = new Stopwatch();
            double elapsedTime = 0;
            List<BasicDataDto> data = generateDummyData.GenerateDummyData(amount);

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                sw.Start();
                foreach (var item in data)
                {
                    outputFile.WriteLine(item.ToString());
                }
                sw.Stop();
                outputFile.Flush();
            }
            elapsedTime = sw.Elapsed.TotalMilliseconds;
            return elapsedTime;
        }
    }
}
