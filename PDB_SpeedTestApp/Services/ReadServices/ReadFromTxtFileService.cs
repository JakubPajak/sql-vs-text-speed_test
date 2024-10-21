using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Services.ReadServices
{
    internal class ReadFromTxtFileService
    {

        public ReadFromTxtFileService()
        {
        }

        public double ReadFromTxtFile(int amount)
        {
            List<string> retrievedData = new List<string>();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "PDB");
            string filePath = Path.Combine(folderPath, "TextFileTest.txt");

            Stopwatch sw = new Stopwatch();

            using(StreamReader streamReader = new StreamReader(filePath))
            {
                sw.Start();
                //while(!streamReader.EndOfStream)
                for(int i = 0; i < amount; i++)
                {
                    retrievedData.Add(streamReader.ReadLine());
                }
                sw.Stop();
            }

            return sw.Elapsed.TotalMilliseconds;
        }

    }
}
