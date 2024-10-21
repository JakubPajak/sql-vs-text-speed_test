using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Services.ReadServices
{
    internal class ReadFromBinFileService
    {
        public ReadFromBinFileService()
        {
        }

        public double ReadFromBinFile(int amount)
        {
            List<string> retrievedData = new List<string>();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "PDB");
            string filePath = Path.Combine(folderPath, "BinFileTest.bin");

            Stopwatch sw = new Stopwatch();

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    sw.Start();
                    //while (fs.Position < fs.Length)
                    for (int i = 0; i < amount; i++)
                    {
                        string name = reader.ReadString();
                        string surname = reader.ReadString();
                        string dateOfBirth = reader.ReadString();
                        string phone = reader.ReadString();

                        retrievedData.Add($"{name},{surname},{dateOfBirth},{phone}");
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
