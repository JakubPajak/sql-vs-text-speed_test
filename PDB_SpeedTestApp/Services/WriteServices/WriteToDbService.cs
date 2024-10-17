using PDB_SpeedTest.Models;
using PDB_SpeedTest.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTestApp.Services.WriteServices
{
    public class WriteToDbService
    {
        private readonly AppDbContext _appDbContext;

        public WriteToDbService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public double WriteToDatabase(int amount)
        {
            Stopwatch sw = new Stopwatch();
            GenerateDummyDataService generateDummyDataService = new GenerateDummyDataService();

            List<BasicDataDto> basicDataDtos = generateDummyDataService.GenerateDummyData(amount);

                sw.Start();
                _appDbContext.AddRange(basicDataDtos);
                _appDbContext.SaveChanges();
                sw.Stop();

            return sw.Elapsed.TotalMilliseconds;
        }
    }
}
