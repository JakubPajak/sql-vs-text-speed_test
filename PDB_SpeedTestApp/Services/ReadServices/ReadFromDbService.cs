using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using PDB_SpeedTestApp.Services;

namespace PDB_SpeedTestApp.Services.ReadServices
{
    internal class ReadFromDbService
    {
        private readonly AppDbContext _appDbContext;

        public ReadFromDbService(AppDbContext context)
        {
            _appDbContext = context;
        }

        public double ReadFromDb(int amount)
        {
            List<string> retrievedData = new List<string>();
            Stopwatch sw = new Stopwatch();

            try
            {
                sw.Start();

                var data = _appDbContext.basicDataDtos.ToList();

                for(int i = 0; i < amount; i++)
                {
                    var item = data[i];
                    retrievedData.Add($"{item.Id},{item.Name},{item.Surname},{item.Phone}");
                }

                sw.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading from the database: {ex.Message}");
                return -1; 
            }

            return sw.Elapsed.TotalMilliseconds;
        }
    }
}
