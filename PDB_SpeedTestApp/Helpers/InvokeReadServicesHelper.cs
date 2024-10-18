using PDB_SpeedTestApp.Services;
using PDB_SpeedTestApp.Services.ReadServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Helpers
{
    internal class InvokeReadServicesHelper
    {
        private AppDbContext _appContext;

        private ReadFromBinFileService _readFromBinFileService;
        private ReadFromCsvFileService _readFromCsvFileService;
        private ReadFromTxtFileService _readFromTxtFileService;
        private ReadFromDbService _readFromDbService;

        public InvokeReadServicesHelper(AppDbContext appContext)
        {
            _appContext = appContext;

            _readFromBinFileService = new ReadFromBinFileService();
            _readFromCsvFileService = new ReadFromCsvFileService();
            _readFromTxtFileService = new ReadFromTxtFileService();
            _readFromDbService = new ReadFromDbService(_appContext);

        }

        public Dictionary<string, double> InvokeReadServices()
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();

            Stopwatch sw = new Stopwatch();

            sw.Start();
            _readFromBinFileService.ReadFromBinFile();
            sw.Stop();
            keyValuePairs.Add("bin", sw.Elapsed.TotalMilliseconds);

            sw.Start();
            _readFromCsvFileService.ReadFromCsvFile();
            sw.Stop();
            keyValuePairs.Add("csv", sw.Elapsed.TotalMilliseconds);
            
            sw.Start();
            _readFromTxtFileService.ReadFromTxtFile();
            sw.Stop();
            keyValuePairs.Add("txt", sw.Elapsed.TotalMilliseconds);
            
            sw.Start();
            _readFromDbService.ReadFromDb();
            sw.Stop();
            keyValuePairs.Add("sql", sw.Elapsed.TotalMilliseconds);


            return keyValuePairs;
        }
    }
}
