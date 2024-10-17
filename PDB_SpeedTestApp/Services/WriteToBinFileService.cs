using PDB_SpeedTest.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTest.Services
{
    internal class WriteToBinFileService
    {
        public WriteToBinFileService()
        {
        }

        public double WriteToBinaryFile(int amount)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "PDB");
            string filePath = Path.Combine(folderPath, "WriteToFileAsync.bin");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            GenerateDummyDataService generateDummyData = new GenerateDummyDataService();

            Stopwatch sw = new Stopwatch();
            double elapsedTime = 0;
            List<BasicDataDto> data = generateDummyData.GenerateDummyData(amount);

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                sw.Start();
                foreach (var item in data)
                {
                    WriteBinary(writer, item);
                }
                sw.Stop();
            }

            elapsedTime = sw.Elapsed.TotalMilliseconds;
            return elapsedTime;
        }
        private void WriteBinary(BinaryWriter writer, BasicDataDto item)
        {
            writer.Write(item.Id);
            writer.Write(item.Name);
            writer.Write(item.Surname);
            writer.Write(item.Phone);
        }
    }
}
