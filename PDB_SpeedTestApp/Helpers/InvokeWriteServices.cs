using PDB_SpeedTestApp.Services;
using PDB_SpeedTestApp.Services.ReadServices;
using PDB_SpeedTestApp.Services.WriteServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Helpers
{
    internal class InvokeWriteServices
    {
        private AppDbContext _dbContext;
        
        private WriteToBinFileService _writeToBinFileService;
        private WriteToCsvFileService _writeToCsvFileService;
        private WriteToTextFileService _writeToToTextFileService;
        private WriteToDbService _writeToDbService;

        private int _amount;
        public InvokeWriteServices(AppDbContext dbContext, int amount)
        {
            _dbContext = dbContext;
            _amount = amount;
            _writeToBinFileService = new WriteToBinFileService();
            _writeToCsvFileService = new WriteToCsvFileService();
            _writeToToTextFileService = new WriteToTextFileService();
            _writeToDbService = new WriteToDbService(_dbContext);
        }

        public Dictionary<string, double> InvokeReadServices()
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            _writeToBinFileService.WriteToBinaryFile(_amount);
            sw.Stop();
            keyValuePairs.Add("bin", sw.Elapsed.TotalMilliseconds);

            sw.Start();
            _writeToCsvFileService.WriteToCsvFile(_amount);
            sw.Stop();
            keyValuePairs.Add("csv", sw.Elapsed.TotalMilliseconds);

            sw.Start();
            _writeToToTextFileService.WriteToTextFile(_amount);
            sw.Stop();
            keyValuePairs.Add("txt", sw.Elapsed.TotalMilliseconds);

            sw.Start();
            _writeToDbService.WriteToDatabase(_amount);
            sw.Stop();
            keyValuePairs.Add("sql", sw.Elapsed.TotalMilliseconds);


            return keyValuePairs;
        }
    }
}
